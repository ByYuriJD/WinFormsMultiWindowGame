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
		private int cardDelayStart;
		private int time = 0; //Время с начала
		private int ghostOffset = 0; //Шатание карты
		private Point origin = Point.Empty; //Положение карты
		private Main main; //Глава
		private int health = 2;

        Random rnd = new Random();
        int shakeAmount;


        private int cooldown = 510;
		public void setOrigin(Point point) {
			origin = point;
		}
		public void setMain(Main main) {
			this.main = main;
		}
		public EnemyCard() {
			InitializeComponent();
		}
		private void worldTimer_Tick(object sender, EventArgs e) {
			time++;

			//Восстановление
			progressBar1.Value = Math.Min(100, (int)Single.Lerp(0, 100, (float)(time - cardDelayStart) / cooldown));
			progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
			progressBar1.Value = Math.Min(100, progressBar1.Value + 1);

			if (time - cardDelayStart >= cooldown) {
				main.attacked();
				cardDelayStart = time;
			}

			//Анимация
			ghostOffset = (int)(Math.Cos(time / 30.0) * 5);
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
		private void button1_Click(object sender, EventArgs e) {
			if (!main.toolFunctional())
				return;
			int item = main.getToolIndex();
			switch (item) {
				case 2:
					health--;
					setBackground();

					main.toolUsed();
					cardDelayStart = time;
					break;
			}
			setBackground();
			if (health <= 0) {
				main.enemyKilled(this);
				Close();
				return;
            }
            shakeAmount = rnd.Next(8, 12);
        }
		private void setBackground() {
			switch (health) {
				case 3:
					button1.BackgroundImage = Image.FromFile("../../../break1.png");
					break;
				case 2:
					button1.BackgroundImage = Image.FromFile("../../../break2.png");
					break;
				case 1:
					button1.BackgroundImage = Image.FromFile("../../../break3.png");
					break;

			}
		}

		public override bool Equals(object? obj) {
			if (!(obj is String))
				return false;
			return (String)obj == "Enemy";
		}

		private void EnemyCard_Load(object sender, EventArgs e) {

			cooldown = 510 - 30 * (main.getProgress() - 5);
		}
	}
}
