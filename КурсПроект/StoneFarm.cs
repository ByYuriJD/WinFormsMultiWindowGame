using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсПроект {
	public partial class StoneFarm : Form {
		public int time = 0; //Время с начала
		private int ghostOffset = 0; //Шатание карты
		private Point origin = Point.Empty; //Положение карты
		private Main main; //Глава

		private String cardType; //Тип карты

		//Время восстановления
		public int cardDelay = 460;
		public int cardDelayStart;
		public StoneFarm() {
			InitializeComponent();
		}
		public void StoneFarm_load() {

			Location = origin;

		}
		//Сеттеры
		public void setOrigin(Point point) {
			origin = point;
		}
		public void setMain(Main main) {
			this.main = main;
		}
		public void setType(String type) {
			this.cardType = type;
		}
		public String getType() {
			return this.cardType;
		}
		public void setDelay(int delay) {
			this.cardDelay = delay;
		}
		//Время
		private void worldTimer_Tick(object sender, EventArgs e) {
			time++;

			//Восстановление
			progressBar1.Value = Math.Max(0, Math.Min(100, (int)Single.Lerp(0, 100, (float)(time - cardDelayStart) / cardDelay)));
			progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
			progressBar1.Value = Math.Min(100, progressBar1.Value + 1);


			//Анимация
			ghostOffset = (int)(Math.Cos(time / 30.0) * 5);
			this.Location = new Point(origin.X,
				origin.Y + ghostOffset);
		}
		//Кнопка
		private void button1_Click(object sender, EventArgs e) {
			if (time - cardDelayStart < cardDelay - 5) //Идёт восстановление
				return;

			if (main.getToolIndex() != 1)
				return;

			main.setStoneCount(main.stoneCount + 1);
			main.toolUsed();

			cardDelayStart = time;
		}
		public override bool Equals(object? obj) {
			if (!(obj is String))
				return false;
			return (String)obj == "StoneFarm";
		}

	}
}
