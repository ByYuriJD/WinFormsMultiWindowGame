namespace КурсПроект {
	partial class Forge {
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
			label1 = new Label();
			priceLabel = new Label();
			progressBar1 = new ProgressBar();
			forgeTick = new System.Windows.Forms.Timer(components);
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonAxe = new Button();
			buttonPick = new Button();
			buttonSword = new Button();
			buttonShield = new Button();
			startForge = new Button();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.AliceBlue;
			label1.Location = new Point(78, 49);
			label1.Name = "label1";
			label1.Size = new Size(78, 17);
			label1.TabIndex = 3;
			label1.Text = "Стоимость:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			priceLabel.ForeColor = Color.AliceBlue;
			priceLabel.Location = new Point(19, 64);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(206, 15);
			priceLabel.TabIndex = 5;
			priceLabel.Text = "100 Дер, 100 Кам, 100 Руд, 100 Жел";
			priceLabel.TextAlign = ContentAlignment.MiddleCenter;
			priceLabel.Click += priceLabel_Click;
			// 
			// progressBar1
			// 
			progressBar1.Dock = DockStyle.Bottom;
			progressBar1.Location = new Point(5, 103);
			progressBar1.Margin = new Padding(3, 2, 3, 2);
			progressBar1.Maximum = 300;
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(230, 10);
			progressBar1.TabIndex = 6;
			// 
			// forgeTick
			// 
			forgeTick.Interval = 20;
			forgeTick.Tick += forgeTick_Tick;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(buttonAxe);
			flowLayoutPanel1.Controls.Add(buttonPick);
			flowLayoutPanel1.Controls.Add(buttonSword);
			flowLayoutPanel1.Controls.Add(buttonShield);
			flowLayoutPanel1.Location = new Point(31, 5);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(179, 44);
			flowLayoutPanel1.TabIndex = 7;
			// 
			// buttonAxe
			// 
			buttonAxe.Dock = DockStyle.Top;
			buttonAxe.Location = new Point(3, 3);
			buttonAxe.Name = "buttonAxe";
			buttonAxe.Size = new Size(38, 38);
			buttonAxe.TabIndex = 0;
			buttonAxe.Text = " <|\r\n  |";
			buttonAxe.UseVisualStyleBackColor = true;
			buttonAxe.Click += buttonAxe_Click;
			// 
			// buttonPick
			// 
			buttonPick.Dock = DockStyle.Top;
			buttonPick.Location = new Point(47, 3);
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
			buttonSword.Location = new Point(91, 3);
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
			buttonShield.Location = new Point(135, 3);
			buttonShield.Name = "buttonShield";
			buttonShield.Size = new Size(38, 38);
			buttonShield.TabIndex = 3;
			buttonShield.Text = "{o}";
			buttonShield.UseVisualStyleBackColor = true;
			buttonShield.Click += buttonShield_Click;
			// 
			// startForge
			// 
			startForge.Dock = DockStyle.Bottom;
			startForge.Location = new Point(5, 78);
			startForge.Name = "startForge";
			startForge.Size = new Size(230, 25);
			startForge.TabIndex = 8;
			startForge.Text = "Запуск";
			startForge.UseVisualStyleBackColor = true;
			startForge.Click += startForge_Click;
			// 
			// Forge
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(240, 118);
			ControlBox = false;
			Controls.Add(startForge);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(progressBar1);
			Controls.Add(priceLabel);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Forge";
			Opacity = 0.2D;
			Padding = new Padding(5);
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			TransparencyKey = Color.DimGray;
			Load += Forge_Load;
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
        private Label priceLabel;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer forgeTick;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonAxe;
		private Button buttonPick;
		private Button buttonSword;
		private Button buttonShield;
		private Button startForge;
	}
}