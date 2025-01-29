namespace КурсПроект {
	partial class StoneFarm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoneFarm));
			progressBar1 = new ProgressBar();
			button1 = new Button();
			worldTimer = new System.Windows.Forms.Timer(components);
			pickNeeded = new Label();
			SuspendLayout();
			// 
			// progressBar1
			// 
			progressBar1.Dock = DockStyle.Bottom;
			progressBar1.Location = new Point(0, 151);
			progressBar1.Margin = new Padding(0);
			progressBar1.MarqueeAnimationSpeed = 1;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(122, 15);
			progressBar1.TabIndex = 5;
			progressBar1.Value = 100;
			// 
			// button1
			// 
			button1.BackColor = Color.MidnightBlue;
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Dock = DockStyle.Fill;
			button1.Font = new Font("Wide Latin", 15F, FontStyle.Bold, GraphicsUnit.Document, 50, true);
			button1.ForeColor = Color.Azure;
			button1.Location = new Point(0, 0);
			button1.Name = "button1";
			button1.Size = new Size(122, 166);
			button1.TabIndex = 4;
			button1.Text = resources.GetString("button1.Text");
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// worldTimer
			// 
			worldTimer.Enabled = true;
			worldTimer.Interval = 5;
			worldTimer.Tick += worldTimer_Tick;
			// 
			// pickNeeded
			// 
			pickNeeded.BackColor = SystemColors.HotTrack;
			pickNeeded.BorderStyle = BorderStyle.Fixed3D;
			pickNeeded.Font = new Font("Showcard Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
			pickNeeded.ForeColor = Color.Navy;
			pickNeeded.Location = new Point(0, 0);
			pickNeeded.Name = "pickNeeded";
			pickNeeded.Size = new Size(32, 30);
			pickNeeded.TabIndex = 6;
			pickNeeded.Text = "- .\r\n  / `";
			pickNeeded.TextAlign = ContentAlignment.MiddleCenter;
			pickNeeded.Visible = false;
			// 
			// StoneFarm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(122, 166);
			ControlBox = false;
			Controls.Add(pickNeeded);
			Controls.Add(progressBar1);
			Controls.Add(button1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "StoneFarm";
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			ResumeLayout(false);
		}

		#endregion

		private ProgressBar progressBar1;
		private Button button1;
		private System.Windows.Forms.Timer worldTimer;
		private Label pickNeeded;
	}
}