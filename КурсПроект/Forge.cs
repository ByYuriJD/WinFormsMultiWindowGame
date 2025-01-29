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

		//Выбранный инструмент
		private int index = 0;
		private int toolProgress = -1;

		//Информация для новых предметов
		private Color highlightColour = Color.DeepPink;
		private int highestUsed = 0;


		//Имена и цены проектов
		public int[,] itemPrices = { { 1, 1, 0, 0 }, { 2, 2, 0, 0 }, { 1, 2, 1, 0 }, { 1, 2, 0, 0 } };

		//Глава
		private Main main;
		public void setMain(Main main) {
			this.main = main;
		}

		public Forge() {
			InitializeComponent();
		}

		//Отображение меню
		public void updateMenu() {
			//Переменные
			int progress = main.getProgress();
			bool progressNotStarted = toolProgress == -1;

			//Кнопки - Прогресс
			buttonAxe.Enabled = progressNotStarted;
			buttonPick.Enabled = progress > 2 && progressNotStarted;
			buttonSword.Enabled = progress > 3 && progressNotStarted;
			buttonShield.Enabled = progress > 4 && progressNotStarted;

			//Новые кнопки
			if (progress == 3 && highestUsed == 0) {
				buttonPick.ForeColor = highlightColour;
			} else if (progress == 4 && highestUsed == 1) {
				buttonSword.ForeColor = highlightColour;
			} else if (progress > 4 && highestUsed == 2) {
				buttonShield.ForeColor = highlightColour;
			}

			//Текст начала
			startForge.Text = main.getToolName(index);

			//Цена
			priceLabel.Text = "";
			priceLabel.Text += itemPrices[index, 0] != 0 ? itemPrices[index, 0] + " Дер " : "";
			priceLabel.Text += itemPrices[index, 1] != 0 ? itemPrices[index, 1] + " Кам " : "";
			priceLabel.Text += itemPrices[index, 2] != 0 ? itemPrices[index, 2] + " Руд " : "";
			priceLabel.Text += itemPrices[index, 3] != 0 ? itemPrices[index, 3] + " Жел " : "";
		}


		//Начать создание инструмента
		private void startForge_Click(object sender, EventArgs e) {
			//Возможность создания инструмента
			if (!main.hasResource(itemPrices[index, 0], itemPrices[index, 1], itemPrices[index, 2], itemPrices[index, 3]))
				return;
			if (toolProgress != -1) {
				toolProgress -= 5;
				return;
			}

			//Использование ресурсов
			main.setWoodCount(main.woodCount - itemPrices[index, 0]);
			main.setStoneCount(main.stoneCount - itemPrices[index, 1]);
			main.setOreCount(main.oreCount - itemPrices[index, 2]);
			main.setIronCount(main.ironCount - itemPrices[index, 3]);

			//Процесс
			forgeTick.Enabled = true;
			toolProgress = 240;

			//Обновление меню
			updateMenu();
		}

		private void Forge_Load(object sender, EventArgs e) {

			updateMenu();
		}

		//Процесс создания инструмента
		private void forgeTick_Tick(object sender, EventArgs e) {
			progressBar1.Value = Math.Min(300, (int)Single.Lerp(300, 0, (float)(Math.Pow(toolProgress, 1.5) / (float)Math.Pow(300, 1.5))));
			progressBar1.Value = Math.Max(progressBar1.Value - 1, 0);
			progressBar1.Value = progressBar1.Value + 1;
			toolProgress--;
			if (toolProgress < 0) {
				toolProgress = -1;
				progressBar1.Value = 0;
				startForge.Enabled = true;
				main.toolBuilt(index);
				updateMenu();
			}
		}

		//+++Кнопки+++
		//Топор
		private void buttonAxe_Click(object sender, EventArgs e) {
			index = 0;
			updateMenu();
		}
		//Кирка
		private void buttonPick_Click(object sender, EventArgs e) {
			index = 1;
			if (highestUsed == 0) {
				highestUsed++;
				buttonPick.ForeColor = Color.Black;
			}
			updateMenu();
		}
		//Меч
		private void buttonSword_Click(object sender, EventArgs e) {
			index = 2;
			if (highestUsed == 1) {
				highestUsed++;
				buttonSword.ForeColor = Color.Black;
			}
			updateMenu();
		}
		//Щит
		private void buttonShield_Click(object sender, EventArgs e) {
			index = 3;
			if (highestUsed == 2) {
				highestUsed++;
				buttonShield.ForeColor = Color.Black;
			}
			updateMenu();
		}
		//---Кнопки---

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

		private void priceLabel_Click(object sender, EventArgs e) {

		}
	}
}
