namespace КурсПроект {
	partial class ResourceCard {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceCard));
            worldTimer = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            button1 = new Button();
            SuspendLayout();
            // 
            // worldTimer
            // 
            worldTimer.Enabled = true;
            worldTimer.Interval = 5;
            worldTimer.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 168);
            progressBar1.Margin = new Padding(0);
            progressBar1.MarqueeAnimationSpeed = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(116, 20);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Wide Latin", 15F, FontStyle.Bold, GraphicsUnit.Document, 50, true);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(116, 188);
            button1.TabIndex = 0;
            button1.Text = resources.GetString("button1.Text");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResourceCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(116, 188);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ResourceCard";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer worldTimer;
		private ProgressBar progressBar1;
        private Button button1;
    }
}
