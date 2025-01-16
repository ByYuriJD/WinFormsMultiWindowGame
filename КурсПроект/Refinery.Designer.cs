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
            RefineryLabel.Location = new Point(10, 10);
            RefineryLabel.Name = "RefineryLabel";
            RefineryLabel.Size = new Size(207, 42);
            RefineryLabel.TabIndex = 0;
            RefineryLabel.Text = "1 руд + 3 дер = 1 жел";
            RefineryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Cornsilk;
            startButton.Dock = DockStyle.Top;
            startButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.Location = new Point(10, 52);
            startButton.Name = "startButton";
            startButton.Size = new Size(207, 37);
            startButton.TabIndex = 1;
            startButton.Text = "запустить печь";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 89);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 20, 5, 0);
            panel1.Size = new Size(207, 106);
            panel1.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ControlLightLight;
            progressBar.Dock = DockStyle.Fill;
            progressBar.ForeColor = Color.DarkOrange;
            progressBar.Location = new Point(5, 20);
            progressBar.Maximum = 200;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(197, 86);
            progressBar.TabIndex = 0;
            // 
            // worldTimer
            // 
            worldTimer.Interval = 10;
            worldTimer.Tick += worldTimer_Tick;
            // 
            // Refinery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(227, 205);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(startButton);
            Controls.Add(RefineryLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Refinery";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
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