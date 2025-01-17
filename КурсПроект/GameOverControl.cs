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
	public partial class GameOverControl : UserControl {
		public GameOverControl(int gameTime) {
			InitializeComponent();
			timeLabel.Text = "Время: ";

			int minutes = gameTime / 6000;
			gameTime = gameTime % 6000;
			timeLabel.Text += minutes.ToString() + " мин, " + (gameTime / 100).ToString() + " сек";
		}
		private void GameOverControl_Load(object sender, EventArgs e) {
			endButton.Enabled = false;
			restartButton.Enabled = false;
		}
		private void endButton_Click(object sender, EventArgs e) {
			ParentForm.DialogResult = DialogResult.Cancel;
			ParentForm.Close();
		}
		private void restartButton_Click(object sender, EventArgs e) {
			ParentForm.DialogResult = DialogResult.Retry;
			ParentForm.Close();
		}
		private void dontQuitTimer_Tick(object sender, EventArgs e) {
			endButton.Enabled=true;
			restartButton.Enabled=true;
			dontQuitTimer.Enabled = false;
		}

	}
}
