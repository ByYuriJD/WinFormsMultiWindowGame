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
		public int[] baseCooldowns = { 300, 350, 400, 100 };

		private Color highlightColour = Color.DeepPink;
		private int highestUsed = 0;

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
		//Отображение меню
		public void updateMenu() {
			//Переменные
			int index = main.getToolIndex();
			int progress = main.getProgress();

			//Инструменты
			buttonAxe.Enabled = true;
			buttonPick.Enabled = progress > 3;
			buttonSword.Enabled = progress > 4;
			buttonShield.Enabled = progress > 4;

			//Новые инструменты
			if (progress == 4 && highestUsed == 0) {
				buttonPick.ForeColor = highlightColour;
			}
			else if (progress == 5 && highestUsed == 1) {
				buttonSword.ForeColor = highlightColour;
			}
			else if (progress > 5 && highestUsed == 2) {
				buttonShield.ForeColor = highlightColour;
			}

			//Восстановление инструмента
			//Инструмент сломан
			if (main.toolDurability[index] == 0) {
				toolCooldown.Value = 1;
				toolCooldown.Value = 0;
				toolCooldown.Value = 0;
			} else { //Инструмент не сломан
				toolCooldown.Maximum = baseCooldowns[index];
				toolCooldown.Value = Math.Max(0,Math.Min(baseCooldowns[index], (int)Single.Lerp(baseCooldowns[index], 0, (float)((float)Math.Pow(toolCooldowns[main.getToolIndex()], 1.5) / (float)Math.Pow(baseCooldowns[index], 1.5)))));
				toolCooldown.Value = Math.Max(toolCooldown.Value - 1, 0);
				toolCooldown.Value = toolCooldown.Value + 1;
			}

			//Здоровье инструмента
			toolHealth.Maximum = main.toolMaxDurability[index] * 100;

			toolHealth.Value = main.toolDurability[index] * 100;
			toolHealth.Value = Math.Max(toolHealth.Value - 1, 0);
			toolHealth.Value = main.toolDurability[index] * 100;
		}
		//Использование текущего инструмента
		public void useTool() {
			toolCooldowns[main.getToolIndex()] = baseCooldowns[main.getToolIndex()];
			updateMenu();
		}
		//Возобнавление восстановления при атаке врага
		public void resetAllCooldowns() {
			for (int i = 0; i < toolCooldowns.Length; i++) {
				toolCooldowns[i] = baseCooldowns[i];
			}
		}

		public Tools() {
			InitializeComponent();
		}

		private void Tools_Load(object sender, EventArgs e) {

			updateMenu();
		}
		//Восстановление
		private void toolCooldownTimer_Tick(object sender, EventArgs e) {
			for (int i = 0; i < toolCooldowns.Length; i++) {

				if (toolCooldowns[i] > 0) {
					toolCooldowns[i]--;
				}

				if (main.toolDurability[i] != 0 && i == main.getToolIndex()) {
					toolCooldown.Maximum = baseCooldowns[i];
					toolCooldown.Value = Math.Min(baseCooldowns[i], (int)Single.Lerp(baseCooldowns[i], 0, (float)((float)Math.Pow(toolCooldowns[main.getToolIndex()], 1.5) / (float)Math.Pow(baseCooldowns[i], 1.5))));
					toolCooldown.Value = Math.Max(toolCooldown.Value - 1, 0);
					toolCooldown.Value = toolCooldown.Value + 1;
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e) {

		}

		//Кнопки инструментов
		//Топор
		private void ButtonAxe_Click(object sender, EventArgs e) {
			main.setToolIndex(0);
			updateMenu();
		}
		//Кирка
		private void buttonPick_Click(object sender, EventArgs e) {
			main.setToolIndex(1);
			if (highestUsed == 0) {
				highestUsed++;
				buttonPick.ForeColor = Color.Black;
			}
			updateMenu();
		}
		//Меч
		private void buttonSword_Click(object sender, EventArgs e) {
			main.setToolIndex(2);
			if (highestUsed == 1) {
				highestUsed++;
				buttonSword.ForeColor = Color.Black;
			}
			updateMenu();
		}
		//Щит
		private void buttonShield_Click(object sender, EventArgs e) {
			main.setToolIndex(3);
			if (highestUsed == 2) {
				highestUsed++;
				buttonShield.ForeColor = Color.Black;
			}
			updateMenu();
		}
	}
}
