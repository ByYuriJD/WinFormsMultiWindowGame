namespace КурсПроект {
    partial class Tools {
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
			toolCooldown = new ProgressBar();
			toolHealth = new ProgressBar();
			toolCooldownTimer = new System.Windows.Forms.Timer(components);
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonAxe = new Button();
			buttonPick = new Button();
			buttonSword = new Button();
			buttonShield = new Button();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// toolCooldown
			// 
			toolCooldown.Location = new Point(48, 50);
			toolCooldown.Margin = new Padding(3, 2, 3, 2);
			toolCooldown.Maximum = 300;
			toolCooldown.Name = "toolCooldown";
			toolCooldown.Size = new Size(167, 9);
			toolCooldown.TabIndex = 3;
			// 
			// toolHealth
			// 
			toolHealth.Dock = DockStyle.Bottom;
			toolHealth.Location = new Point(4, 63);
			toolHealth.Margin = new Padding(3, 2, 3, 2);
			toolHealth.MarqueeAnimationSpeed = 1000;
			toolHealth.Maximum = 1000;
			toolHealth.Name = "toolHealth";
			toolHealth.Size = new Size(257, 20);
			toolHealth.TabIndex = 4;
			// 
			// toolCooldownTimer
			// 
			toolCooldownTimer.Enabled = true;
			toolCooldownTimer.Interval = 20;
			toolCooldownTimer.Tick += toolCooldownTimer_Tick;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(buttonAxe);
			flowLayoutPanel1.Controls.Add(buttonPick);
			flowLayoutPanel1.Controls.Add(buttonSword);
			flowLayoutPanel1.Controls.Add(buttonShield);
			flowLayoutPanel1.Dock = DockStyle.Top;
			flowLayoutPanel1.Location = new Point(4, 4);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(35, 0, 0, 0);
			flowLayoutPanel1.Size = new Size(257, 41);
			flowLayoutPanel1.TabIndex = 5;
			// 
			// buttonAxe
			// 
			buttonAxe.Dock = DockStyle.Top;
			buttonAxe.Font = new Font("Segoe UI", 9F);
			buttonAxe.ForeColor = Color.Black;
			buttonAxe.Location = new Point(38, 3);
			buttonAxe.Name = "buttonAxe";
			buttonAxe.Size = new Size(38, 38);
			buttonAxe.TabIndex = 0;
			buttonAxe.Text = " <|\r\n  |";
			buttonAxe.UseVisualStyleBackColor = true;
			buttonAxe.Click += ButtonAxe_Click;
			// 
			// buttonPick
			// 
			buttonPick.Dock = DockStyle.Top;
			buttonPick.Location = new Point(82, 3);
			buttonPick.Name = "buttonPick";
			buttonPick.Size = new Size(38, 38);
			buttonPick.TabIndex = 1;
			buttonPick.Text = "- .\r\n /  `";
			buttonPick.UseVisualStyleBackColor = true;
			buttonPick.Click += buttonPick_Click;
			// 
			// buttonSword
			// 
			buttonSword.Dock = DockStyle.Top;
			buttonSword.Location = new Point(126, 3);
			buttonSword.Name = "buttonSword";
			buttonSword.Size = new Size(38, 38);
			buttonSword.TabIndex = 2;
			buttonSword.Text = "_A_\r\n|";
			buttonSword.UseVisualStyleBackColor = true;
			buttonSword.Click += buttonSword_Click;
			// 
			// buttonShield
			// 
			buttonShield.Dock = DockStyle.Top;
			buttonShield.Location = new Point(170, 3);
			buttonShield.Name = "buttonShield";
			buttonShield.Size = new Size(38, 38);
			buttonShield.TabIndex = 3;
			buttonShield.Text = "{o}";
			buttonShield.UseVisualStyleBackColor = true;
			buttonShield.Click += buttonShield_Click;
			// 
			// Tools
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Tan;
			ClientSize = new Size(265, 87);
			ControlBox = false;
			Controls.Add(flowLayoutPanel1);
			Controls.Add(toolHealth);
			Controls.Add(toolCooldown);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Tools";
			Padding = new Padding(4);
			ShowInTaskbar = false;
			TopMost = true;
			Load += Tools_Load;
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private ProgressBar toolCooldown;
        private ProgressBar toolHealth;
        private System.Windows.Forms.Timer toolCooldownTimer;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonAxe;
		private Button buttonPick;
		private Button buttonSword;
		private Button buttonShield;
	}
}