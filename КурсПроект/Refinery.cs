﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КурсПроект {
    public partial class Refinery : Form {
        //Переменные для переноса карты
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        //Время до создания железа
        private int refineProgress = -1;

        //Глава
        private Main main;
        public void setMain(Main main) {
            this.main = main;
        }

        public Refinery() {
            InitializeComponent();
        }
        //Код для переноса карты
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }
        //Начало обработки
        private void startButton_Click(object sender, EventArgs e) {
            if (!main.hasResource(3, 0, 1, 0))
                return;
			if (refineProgress != -1) {
                if (refineProgress > 10) {
					refineProgress -= 10;
				}
                return;
            }
				main.setWoodCount(main.woodCount - 3);
            main.setOreCount(main.oreCount - 1);

            worldTimer.Enabled = true;
            refineProgress = 1000;
        }
        //Процесс обработки
        private void worldTimer_Tick(object sender, EventArgs e) {
            progressBar.Value = Math.Min(1000, (int)Single.Lerp(200, 0, (float)(Math.Pow(refineProgress, 1.5) / (float)Math.Pow(1000, 1.5))));
            progressBar.Value = Math.Max(progressBar.Value - 1, 0);
            progressBar.Value = progressBar.Value + 1;

            //Прогресс
            refineProgress--;
            if (refineProgress < 0) {
                refineProgress = -1;
                progressBar.Value = 0;
                worldTimer.Enabled = false;
                main.setIronCount(main.ironCount + 1);
            }
        }
    }
}
