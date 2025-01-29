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

        Random rnd = new Random();
        int shakeAmount;

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
		//Кнопка
		private void button1_Click(object sender, EventArgs e) {
			if (time - cardDelayStart < cardDelay - 5) //Идёт восстановление
				return;

			if (main.getToolIndex() != 1 || main.toolFunctional())
				return;

			main.setStoneCount(main.stoneCount + 2);
			main.toolUsed();

			cardDelayStart = time;
            shakeAmount = rnd.Next(8, 12);
        }
		public override bool Equals(object? obj) {
			if (!(obj is String))
				return false;
			return (String)obj == "StoneFarm";
		}

	}
}
