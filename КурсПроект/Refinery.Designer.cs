namespace КурсПроект {
    partial class Refinery {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			RefineryLabel = new Label();
			startButton = new Button();
			panel1 = new Panel();
			progressBar = new ProgressBar();
			worldTimer = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// RefineryLabel
			// 
			RefineryLabel.Dock = DockStyle.Top;
			RefineryLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			RefineryLabel.ForeColor = Color.Cornsilk;
			RefineryLabel.Location = new Point(9, 8);
			RefineryLabel.Name = "RefineryLabel";
			RefineryLabel.Size = new Size(173, 32);
			RefineryLabel.TabIndex = 0;
			RefineryLabel.Text = "1 руд + 3 дер = 1 жел";
			RefineryLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// startButton
			// 
			startButton.BackColor = Color.Cornsilk;
			startButton.Dock = DockStyle.Top;
			startButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			startButton.Location = new Point(9, 40);
			startButton.Margin = new Padding(3, 2, 3, 2);
			startButton.Name = "startButton";
			startButton.Size = new Size(173, 28);
			startButton.TabIndex = 1;
			startButton.Text = "запустить печь";
			startButton.UseVisualStyleBackColor = false;
			startButton.Click += startButton_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(progressBar);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(9, 68);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(4, 15, 4, 0);
			panel1.Size = new Size(173, 70);
			panel1.TabIndex = 2;
			// 
			// progressBar
			// 
			progressBar.BackColor = SystemColors.ControlLightLight;
			progressBar.Dock = DockStyle.Fill;
			progressBar.ForeColor = Color.DarkOrange;
			progressBar.Location = new Point(4, 15);
			progressBar.Margin = new Padding(3, 2, 3, 2);
			progressBar.Maximum = 200;
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(165, 55);
			progressBar.TabIndex = 0;
			// 
			// worldTimer
			// 
			worldTimer.Interval = 15;
			worldTimer.Tick += worldTimer_Tick;
			// 
			// Refinery
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(191, 146);
			ControlBox = false;
			Controls.Add(panel1);
			Controls.Add(startButton);
			Controls.Add(RefineryLabel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Refinery";
			Padding = new Padding(9, 8, 9, 8);
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label RefineryLabel;
        private Button startButton;
        private Panel panel1;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer worldTimer;
    }
}