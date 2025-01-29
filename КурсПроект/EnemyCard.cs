using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace КурсПроект {
	public partial class EnemyCard : Form {

		private int time = 0; //Время с начала

		private int ghostOffset = 0; //Шатание карты
		private Point origin = Point.Empty; //Положение карты
		private Main main; //Глава

		private int health = 2; //Здоровье

		//Для тряски
		Random rnd = new Random();
		int shakeAmount;

		//Время восстановления для атаки
		public int baseCardDelay = 510;
		public int currentCardDelay;

		//Сеттеры
		public void setOrigin(Point point) {
			origin = point;
		}
		public void setMain(Main main) {
			this.main = main;
		}

		public EnemyCard() {
			InitializeComponent();
			currentCardDelay = baseCardDelay;
		}

		//Время прооцесса
		private void worldTimer_Tick(object sender, EventArgs e) {
			time++;

			//Восстановление
			progressBar1.Value = Math.Min(100, (int)Single.Lerp(0, 100, 1 - (float)currentCardDelay / baseCardDelay));
			progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
			progressBar1.Value = Math.Min(100, progressBar1.Value + 1);

			//Аттака при восстановлении
			if (currentCardDelay <= 0) {
				main.attacked();
				currentCardDelay = baseCardDelay;
			}

			//Анимация
			ghostOffset = (int)(Math.Cos(time / 15.0) * 5);
			Point ghostOrigin = new Point(origin.X,
				origin.Y + ghostOffset);
			if (shakeAmount != 0) {
				int shakeAmplitude = shakeAmount / 4;
				Location = new Point(ghostOrigin.X + rnd.Next(-shakeAmplitude, shakeAmplitude), ghostOrigin.Y + rnd.Next(-shakeAmplitude, shakeAmplitude));
				shakeAmount--;
				return;
			}
			Location = ghostOrigin;
		}

		//Восстановление
		private void cardDelay_Tick(object sender, EventArgs e) {
			currentCardDelay--;
		}

		//Нажатие на врага
		private void button1_Click(object sender, EventArgs e) {

			//Используется меч, он не востанавливается
			if ( main.getToolIndex() != 2 || !main.toolFunctional())
				return;
			main.toolUsed();

			//Здоровье
			health--;
			if (health <= 0) {
				main.enemyKilled(this);
				Close();
				return;
			}

			// Другой функционал
			currentCardDelay = baseCardDelay;

			//Визуальные эффекты
			setBackground();
			shakeAmount = rnd.Next(8, 12);
		}

		//Заменяет фон взависимости от здоровья
		private void setBackground() {
			switch (health) {
				case 1:
					button1.BackgroundImage = Image.FromFile("../../../break3.png");
					break;

			}
		}

		//Проверка на то, что карта - враг
		public override bool Equals(object? obj) {
			if (!(obj is String))
				return false;
			return (String)obj == "Enemy";
		}

		private void EnemyCard_Load(object sender, EventArgs e) {
		}

	}
}
