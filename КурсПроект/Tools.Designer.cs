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
            buttonLeft.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonLeft.Location = new Point(12, 12);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(38, 60);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonRight.Location = new Point(253, 12);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(38, 60);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // label1
            // 
            label1.Location = new Point(122, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 36);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolCooldown
            // 
            toolCooldown.Location = new Point(56, 51);
            toolCooldown.Maximum = 300;
            toolCooldown.Name = "toolCooldown";
            toolCooldown.Size = new Size(191, 12);
            toolCooldown.TabIndex = 3;
            // 
            // toolHealth
            // 
            toolHealth.Location = new Point(12, 78);
            toolHealth.MarqueeAnimationSpeed = 1000;
            toolHealth.Maximum = 1000;
            toolHealth.Name = "toolHealth";
            toolHealth.Size = new Size(279, 26);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(303, 116);
            ControlBox = false;
            Controls.Add(toolHealth);
            Controls.Add(toolCooldown);
            Controls.Add(label1);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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