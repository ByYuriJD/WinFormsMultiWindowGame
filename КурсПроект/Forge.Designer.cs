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
            buttonLeft = new Button();
            buttonRight = new Button();
            label1 = new Label();
            startForge = new Button();
            priceLabel = new Label();
            progressBar1 = new ProgressBar();
            forgeTick = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonLeft.Location = new Point(12, 12);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(40, 38);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonRight
            // 
            buttonRight.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonRight.Location = new Point(254, 12);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(41, 38);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(103, 53);
            label1.Name = "label1";
            label1.Size = new Size(94, 27);
            label1.TabIndex = 3;
            label1.Text = "Стоимость:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startForge
            // 
            startForge.BackColor = SystemColors.ButtonFace;
            startForge.Font = new Font("Segoe UI", 10F);
            startForge.Location = new Point(58, 12);
            startForge.Name = "startForge";
            startForge.Size = new Size(190, 38);
            startForge.TabIndex = 4;
            startForge.Text = "label1";
            startForge.UseVisualStyleBackColor = false;
            startForge.Click += startForge_Click;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            priceLabel.ForeColor = Color.AliceBlue;
            priceLabel.Location = new Point(12, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(283, 23);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "100 Дер, 100 Кам, 100 Руд, 100 Жел\r\n\r\n\r\n\r\n";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 106);
            progressBar1.Maximum = 300;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(283, 14);
            progressBar1.TabIndex = 6;
            // 
            // forgeTick
            // 
            forgeTick.Tick += forgeTick_Tick;
            // 
            // Forge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(299, 112);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(priceLabel);
            Controls.Add(startForge);
            Controls.Add(label1);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Forge";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            Load += Forge_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLeft;
        private Button buttonRight;
        private Label label1;
        private Button startForge;
        private Label priceLabel;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer forgeTick;
    }
}