﻿namespace КурсПроект {
    partial class EnemyCard {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnemyCard));
			progressBar1 = new ProgressBar();
			button1 = new Button();
			worldTimer = new System.Windows.Forms.Timer(components);
			swordNeeded = new Label();
			cardDelay = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// progressBar1
			// 
			progressBar1.Dock = DockStyle.Bottom;
			progressBar1.Location = new Point(0, 141);
			progressBar1.Margin = new Padding(0, 4, 0, 4);
			progressBar1.MarqueeAnimationSpeed = 1;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(112, 15);
			progressBar1.TabIndex = 3;
			progressBar1.Value = 100;
			// 
			// button1
			// 
			button1.BackColor = Color.Crimson;
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Cursor = Cursors.Hand;
			button1.Dock = DockStyle.Fill;
			button1.Font = new Font("Segoe UI", 3F, FontStyle.Bold, GraphicsUnit.Pixel, 204);
			button1.Location = new Point(0, 0);
			button1.Margin = new Padding(0, 4, 0, 4);
			button1.Name = "button1";
			button1.Size = new Size(112, 156);
			button1.TabIndex = 2;
			button1.Text = resources.GetString("button1.Text");
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// worldTimer
			// 
			worldTimer.Enabled = true;
			worldTimer.Interval = 30;
			worldTimer.Tick += worldTimer_Tick;
			// 
			// swordNeeded
			// 
			swordNeeded.BackColor = Color.IndianRed;
			swordNeeded.BorderStyle = BorderStyle.Fixed3D;
			swordNeeded.Font = new Font("Showcard Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
			swordNeeded.Location = new Point(0, 0);
			swordNeeded.Name = "swordNeeded";
			swordNeeded.Size = new Size(32, 30);
			swordNeeded.TabIndex = 4;
			swordNeeded.Text = "_A_\r\n|";
			swordNeeded.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cardDelay
			// 
			cardDelay.Enabled = true;
			cardDelay.Interval = 15;
			cardDelay.Tick += cardDelay_Tick;
			// 
			// EnemyCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(112, 156);
			ControlBox = false;
			Controls.Add(swordNeeded);
			Controls.Add(progressBar1);
			Controls.Add(button1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Margin = new Padding(0, 4, 0, 4);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			MinimumSize = new Size(122, 166);
			Name = "EnemyCard";
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			Load += EnemyCard_Load;
			ResumeLayout(false);
		}

		#endregion

		private ProgressBar progressBar1;
        private Button button1;
        private System.Windows.Forms.Timer worldTimer;
		private Label swordNeeded;
		private System.Windows.Forms.Timer cardDelay;
	}
}