using System;
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
    public partial class Tools : Form {
        //Переменные для переноса карты
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public int[] toolCooldowns = { 0, 0, 0, 0 };
        public int[] baseCooldowns = {300, 350, 500, 500};

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
        public void updateMenu() {
            int index = main.getToolIndex();
            buttonLeft.Enabled = index != 0;
            buttonRight.Enabled = main.itemAccessibility[index + 1] <= main.getProgress();

            label1.Text = main.getToolName(index);

            if (main.toolDurability[index] == 0) {
                toolCooldown.Value = 1;
                toolCooldown.Value = 0;
                toolCooldown.Value = 0;
            } else {
                toolCooldown.Value = Math.Min(300, (int)Single.Lerp(300, 0, (float)((float)Math.Pow(toolCooldowns[main.getToolIndex()], 1.5) / (float)Math.Pow(300, 1.5))));
                toolCooldown.Value = Math.Max(toolCooldown.Value - 1, 0);
                toolCooldown.Value = toolCooldown.Value + 1;
            }

            toolHealth.Value = main.toolDurability[index] * 100;
            toolHealth.Value = Math.Max(toolHealth.Value - 1, 0);
            toolHealth.Value = main.toolDurability[index] * 100;
        }

        public void useTool() {
            toolCooldowns[main.getToolIndex()] = 300;
            updateMenu();
        }

        public Tools() {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e) {
            if (main.getToolIndex() == 0)
                return;
            main.setToolIndex(main.getToolIndex() - 1);
            updateMenu();
        }

        private void buttonRight_Click(object sender, EventArgs e) {
            if (main.itemAccessibility[main.getToolIndex() + 1] > main.getProgress())
                return;
            main.setToolIndex(main.getToolIndex() + 1);
            updateMenu();

        }
        private void Tools_Load(object sender, EventArgs e) {

            updateMenu();
        }
        private void toolCooldownTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < toolCooldowns.Length; i++) {

                if (toolCooldowns[i] > 0) {
                    toolCooldowns[i]--;
                }

                if (main.toolDurability[i] != 0 && i == main.getToolIndex()) {
                    toolCooldown.Value = Math.Min(300, (int)Single.Lerp(300, 0, (float)((float)Math.Pow(toolCooldowns[main.getToolIndex()], 1.5) / (float)Math.Pow(300, 1.5))));
                    toolCooldown.Value = Math.Max(toolCooldown.Value - 1, 0);
                    toolCooldown.Value = toolCooldown.Value + 1;
                } 
            }
        }

    }
}
