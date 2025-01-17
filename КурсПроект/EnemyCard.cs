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
            progressBar1.Value = Math.Min(100, (int)Single.Lerp(0, 100, (float)(time-cardDelayStart) / cooldown));
            progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
            progressBar1.Value = Math.Min(100, progressBar1.Value + 1);


            //Анимация
            ghostOffset = (int)(Math.Cos(time / 30.0) * 5);
            this.Location = new Point(origin.X + ghostOffset,
                origin.Y);

            if (cardDelayStart+ cooldown <= time+5) {
                cardDelayStart = time;
                main.attacked();
            }
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
            if (health <= 0) {
                main.enemyKilled(this);
                Close();
                return;
            }
        }
        private void setBackground() {
            //switch (health) {
            //    case 3:
            //        button1.BackgroundImage = Image.FromFile("../images/break1.png");
            //        break;
            //    case 2:
            //        button1.BackgroundImage = Image.FromFile("../images/break2.png");
            //        break;
            //    case 1:
            //        button1.BackgroundImage = Image.FromFile("../images/break3.png");
            //        break;

            //}
        }

        public override bool Equals(object? obj) {
            if (!(obj is String))
                return false;
            return (String)obj == "Enemy";
        }
    }
}
