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
			buttonLeft = new Button();
			buttonRight = new Button();
			label1 = new Label();
			toolCooldown = new ProgressBar();
			toolHealth = new ProgressBar();
			toolCooldownTimer = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// buttonLeft
			// 
			buttonLeft.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLeft.Location = new Point(10, 9);
			buttonLeft.Margin = new Padding(3, 2, 3, 2);
			buttonLeft.Name = "buttonLeft";
			buttonLeft.Size = new Size(33, 45);
			buttonLeft.TabIndex = 0;
			buttonLeft.Text = "<";
			buttonLeft.UseVisualStyleBackColor = true;
			buttonLeft.Click += buttonLeft_Click;
			// 
			// buttonRight
			// 
			buttonRight.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonRight.Location = new Point(221, 9);
			buttonRight.Margin = new Padding(3, 2, 3, 2);
			buttonRight.Name = "buttonRight";
			buttonRight.Size = new Size(33, 45);
			buttonRight.TabIndex = 1;
			buttonRight.Text = ">";
			buttonRight.UseVisualStyleBackColor = true;
			buttonRight.Click += buttonRight_Click;
			// 
			// label1
			// 
			label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(107, 9);
			label1.Name = "label1";
			label1.Size = new Size(47, 27);
			label1.TabIndex = 2;
			label1.Text = "label1";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// toolCooldown
			// 
			toolCooldown.Location = new Point(49, 38);
			toolCooldown.Margin = new Padding(3, 2, 3, 2);
			toolCooldown.Maximum = 300;
			toolCooldown.Name = "toolCooldown";
			toolCooldown.Size = new Size(167, 9);
			toolCooldown.TabIndex = 3;
			// 
			// toolHealth
			// 
			toolHealth.Location = new Point(10, 58);
			toolHealth.Margin = new Padding(3, 2, 3, 2);
			toolHealth.MarqueeAnimationSpeed = 1000;
			toolHealth.Maximum = 1000;
			toolHealth.Name = "toolHealth";
			toolHealth.Size = new Size(244, 20);
			toolHealth.TabIndex = 4;
			// 
			// toolCooldownTimer
			// 
			toolCooldownTimer.Enabled = true;
			toolCooldownTimer.Interval = 20;
			toolCooldownTimer.Tick += toolCooldownTimer_Tick;
			// 
			// Tools
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Tan;
			ClientSize = new Size(265, 87);
			ControlBox = false;
			Controls.Add(toolHealth);
			Controls.Add(toolCooldown);
			Controls.Add(label1);
			Controls.Add(buttonRight);
			Controls.Add(buttonLeft);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Tools";
			ShowInTaskbar = false;
			TopMost = true;
			Load += Tools_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button buttonLeft;
        private Button buttonRight;
        private Label label1;
        private ProgressBar toolCooldown;
        private ProgressBar toolHealth;
        private System.Windows.Forms.Timer toolCooldownTimer;
    }
}