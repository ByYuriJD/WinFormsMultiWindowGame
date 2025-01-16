using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace КурсПроект {


    public partial class Forge : Form {
        //Переменные для переноса карты
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;


        private int index = 0;
        private int toolProgress = -1;

        //Имена и цены проектов
        public int[,] itemPrices = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        private Main main;
        public void setMain(Main main) {
            this.main = main;
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
        public Forge() {
            InitializeComponent();
        }


        public void updateMenu() {
            buttonLeft.Enabled = index != 0 && toolProgress==-1;
            buttonRight.Enabled = main.itemAccessibility[index + 1] <= main.getProgress() && toolProgress == -1;


            startForge.Text = main.getToolName(index);

            priceLabel.Text = "";
            priceLabel.Text += itemPrices[index, 0] != 0 ? itemPrices[index, 0] + " Дер " : "";
            priceLabel.Text += itemPrices[index, 1] != 0 ? itemPrices[index, 1] + " Кам " : "";
            priceLabel.Text += itemPrices[index, 2] != 0 ? itemPrices[index, 2] + " Руд " : "";
            priceLabel.Text += itemPrices[index, 3] != 0 ? itemPrices[index, 3] + " Жел " : "";
        }

        private void buttonLeft_Click(object sender, EventArgs e) {
            if (index == 0)
                return;
            index--;
            updateMenu();
        }

        private void buttonRight_Click(object sender, EventArgs e) {
            if (main.itemAccessibility[index + 1] > main.getProgress())
                return;
            index++;
            updateMenu();
        }

        private void startForge_Click(object sender, EventArgs e) {
            if (toolProgress != -1 || !main.hasResource(itemPrices[index, 0], itemPrices[index, 1], itemPrices[index, 2], itemPrices[index, 3]))
                return;
            
            main.setWoodCount(main.woodCount - itemPrices[index, 0]);
            main.setStoneCount(main.stoneCount - itemPrices[index, 1]);
            main.setOreCount(main.stoneCount - itemPrices[index, 2]);
            main.setIronCount(main.stoneCount - itemPrices[index, 3]);

            startForge.Enabled = false;
            forgeTick.Enabled = true;
            toolProgress = 5;
            updateMenu();
        }

        private void Forge_Load(object sender, EventArgs e) {

            updateMenu();
        }

        private void forgeTick_Tick(object sender, EventArgs e) {
            progressBar1.Value = Math.Min(300, (int)Single.Lerp(300, 0, (float)(Math.Pow(toolProgress, 1.5) / (float)Math.Pow(300, 1.5))));
            progressBar1.Value = Math.Max(progressBar1.Value - 1, 0);
            progressBar1.Value = progressBar1.Value + 1;
            toolProgress--;
            if (toolProgress < 0) {
                toolProgress = -1;
                progressBar1.Value = 0;
                forgeTick.Enabled = false;
                startForge.Enabled = true;
                main.toolBuilt(index);
                updateMenu();
            }
        }
    }
}
