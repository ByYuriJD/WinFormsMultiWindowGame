namespace КурсПроект {
	partial class Main {
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
			woodLabel = new Label();
			oreLabel = new Label();
			ironLabel = new Label();
			woodStat = new Label();
			oreStat = new Label();
			ironStat = new Label();
			stoneStat = new Label();
			stoneLabel = new Label();
			resourceSpawner = new System.Windows.Forms.Timer(components);
			woodPrice = new Label();
			orePrice = new Label();
			ironPrice = new Label();
			stonePrice = new Label();
			projectButton = new Button();
			priceLabel = new Label();
			buildBar = new ProgressBar();
			buildTimer = new System.Windows.Forms.Timer(components);
			projectName = new Label();
			gameTimer = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// woodLabel
			// 
			woodLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			woodLabel.Location = new Point(138, 19);
			woodLabel.Name = "woodLabel";
			woodLabel.Size = new Size(100, 32);
			woodLabel.TabIndex = 0;
			woodLabel.Text = "Дерево";
			woodLabel.TextAlign = ContentAlignment.MiddleCenter;
			woodLabel.Click += woodLabel_Click;
			// 
			// oreLabel
			// 
			oreLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			oreLabel.Location = new Point(350, 19);
			oreLabel.Name = "oreLabel";
			oreLabel.Size = new Size(100, 32);
			oreLabel.TabIndex = 1;
			oreLabel.Text = "Руда";
			oreLabel.TextAlign = ContentAlignment.MiddleCenter;
			oreLabel.Click += oreLabel_Click;
			// 
			// ironLabel
			// 
			ironLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ironLabel.Location = new Point(456, 19);
			ironLabel.Name = "ironLabel";
			ironLabel.Size = new Size(100, 32);
			ironLabel.TabIndex = 2;
			ironLabel.Text = "Железо";
			ironLabel.TextAlign = ContentAlignment.MiddleCenter;
			ironLabel.Click += ironLabel_Click;
			// 
			// woodStat
			// 
			woodStat.Font = new Font("Showcard Gothic", 12F);
			woodStat.Location = new Point(138, 66);
			woodStat.MinimumSize = new Size(50, 0);
			woodStat.Name = "woodStat";
			woodStat.Size = new Size(100, 20);
			woodStat.TabIndex = 3;
			woodStat.Text = "label1";
			woodStat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// oreStat
			// 
			oreStat.Font = new Font("Showcard Gothic", 12F);
			oreStat.Location = new Point(350, 66);
			oreStat.MinimumSize = new Size(50, 0);
			oreStat.Name = "oreStat";
			oreStat.Size = new Size(100, 20);
			oreStat.TabIndex = 4;
			oreStat.Text = "label1";
			oreStat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ironStat
			// 
			ironStat.Font = new Font("Showcard Gothic", 12F);
			ironStat.Location = new Point(456, 66);
			ironStat.MinimumSize = new Size(50, 0);
			ironStat.Name = "ironStat";
			ironStat.Size = new Size(100, 20);
			ironStat.TabIndex = 4;
			ironStat.Text = "label1";
			ironStat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// stoneStat
			// 
			stoneStat.Font = new Font("Showcard Gothic", 12F);
			stoneStat.Location = new Point(244, 66);
			stoneStat.MinimumSize = new Size(50, 0);
			stoneStat.Name = "stoneStat";
			stoneStat.Size = new Size(100, 20);
			stoneStat.TabIndex = 6;
			stoneStat.Text = "label1";
			stoneStat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// stoneLabel
			// 
			stoneLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			stoneLabel.Location = new Point(244, 19);
			stoneLabel.Name = "stoneLabel";
			stoneLabel.Size = new Size(100, 32);
			stoneLabel.TabIndex = 5;
			stoneLabel.Text = "Камень";
			stoneLabel.TextAlign = ContentAlignment.MiddleCenter;
			stoneLabel.Click += stoneLabel_Click;
			// 
			// resourceSpawner
			// 
			resourceSpawner.Interval = 1000;
			resourceSpawner.Tick += resourceSpawner_Tick;
			// 
			// woodPrice
			// 
			woodPrice.Font = new Font("Showcard Gothic", 12F);
			woodPrice.Location = new Point(138, 111);
			woodPrice.MinimumSize = new Size(50, 0);
			woodPrice.Name = "woodPrice";
			woodPrice.Size = new Size(100, 20);
			woodPrice.TabIndex = 3;
			woodPrice.Text = "label1";
			woodPrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// orePrice
			// 
			orePrice.Font = new Font("Showcard Gothic", 12F);
			orePrice.Location = new Point(350, 111);
			orePrice.MinimumSize = new Size(50, 0);
			orePrice.Name = "orePrice";
			orePrice.Size = new Size(100, 20);
			orePrice.TabIndex = 4;
			orePrice.Text = "label1";
			orePrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ironPrice
			// 
			ironPrice.Font = new Font("Showcard Gothic", 12F);
			ironPrice.Location = new Point(456, 111);
			ironPrice.MinimumSize = new Size(50, 0);
			ironPrice.Name = "ironPrice";
			ironPrice.Size = new Size(100, 20);
			ironPrice.TabIndex = 4;
			ironPrice.Text = "label1";
			ironPrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// stonePrice
			// 
			stonePrice.Font = new Font("Showcard Gothic", 12F);
			stonePrice.Location = new Point(244, 111);
			stonePrice.MinimumSize = new Size(50, 0);
			stonePrice.Name = "stonePrice";
			stonePrice.Size = new Size(100, 20);
			stonePrice.TabIndex = 6;
			stonePrice.Text = "label1";
			stonePrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// projectButton
			// 
			projectButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			projectButton.Location = new Point(4, 62);
			projectButton.Name = "projectButton";
			projectButton.Size = new Size(126, 30);
			projectButton.TabIndex = 7;
			projectButton.Text = "начать стройку";
			projectButton.UseVisualStyleBackColor = true;
			projectButton.Click += projectButton_Click;
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			priceLabel.Location = new Point(30, 111);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(74, 15);
			priceLabel.TabIndex = 8;
			priceLabel.Text = "стоимость:";
			// 
			// buildBar
			// 
			buildBar.Location = new Point(12, 98);
			buildBar.Name = "buildBar";
			buildBar.Size = new Size(112, 10);
			buildBar.TabIndex = 9;
			// 
			// buildTimer
			// 
			buildTimer.Interval = 5;
			buildTimer.Tick += buildTimer_Tick;
			// 
			// projectName
			// 
			projectName.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			projectName.Location = new Point(4, 9);
			projectName.Name = "projectName";
			projectName.Size = new Size(132, 50);
			projectName.TabIndex = 10;
			projectName.Text = "Дерево";
			projectName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// gameTimer
			// 
			gameTimer.Enabled = true;
			gameTimer.Interval = 1000;
			gameTimer.Tick += gameTimer_Tick;
			// 
			// Main
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(574, 140);
			Controls.Add(projectName);
			Controls.Add(buildBar);
			Controls.Add(priceLabel);
			Controls.Add(projectButton);
			Controls.Add(stonePrice);
			Controls.Add(stoneStat);
			Controls.Add(stoneLabel);
			Controls.Add(ironPrice);
			Controls.Add(orePrice);
			Controls.Add(ironStat);
			Controls.Add(woodPrice);
			Controls.Add(oreStat);
			Controls.Add(woodStat);
			Controls.Add(ironLabel);
			Controls.Add(oreLabel);
			Controls.Add(woodLabel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Main";
			ShowIcon = false;
			TopMost = true;
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label woodLabel;
		private Label oreLabel;
		private Label ironLabel;
		private Label woodStat;
		private Label oreStat;
		private Label ironStat;
		private Label stoneStat;
		private Label stoneLabel;
		private System.Windows.Forms.Timer resourceSpawner;
		private Label woodPrice;
		private Label orePrice;
		private Label ironPrice;
		private Label stonePrice;
		private Button projectButton;
		private Label priceLabel;
		private ProgressBar buildBar;
		private Label projectName;
		private System.Windows.Forms.Timer buildTimer;
		private System.Windows.Forms.Timer gameTimer;
	}
}