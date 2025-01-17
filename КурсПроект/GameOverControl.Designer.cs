namespace КурсПроект {
	partial class GameOverControl {
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			leftPanel = new Panel();
			buttonsPanel = new Panel();
			endButton = new Button();
			restartButton = new Button();
			label1 = new Label();
			fullDock = new Panel();
			timeLabel = new Label();
			dontQuitTimer = new System.Windows.Forms.Timer(components);
			leftPanel.SuspendLayout();
			buttonsPanel.SuspendLayout();
			fullDock.SuspendLayout();
			SuspendLayout();
			// 
			// leftPanel
			// 
			leftPanel.Controls.Add(buttonsPanel);
			leftPanel.Controls.Add(label1);
			leftPanel.Dock = DockStyle.Left;
			leftPanel.Location = new Point(0, 0);
			leftPanel.Name = "leftPanel";
			leftPanel.Size = new Size(161, 142);
			leftPanel.TabIndex = 0;
			// 
			// buttonsPanel
			// 
			buttonsPanel.Controls.Add(endButton);
			buttonsPanel.Controls.Add(restartButton);
			buttonsPanel.Dock = DockStyle.Fill;
			buttonsPanel.Location = new Point(0, 40);
			buttonsPanel.Name = "buttonsPanel";
			buttonsPanel.Padding = new Padding(10);
			buttonsPanel.Size = new Size(161, 102);
			buttonsPanel.TabIndex = 1;
			// 
			// endButton
			// 
			endButton.DialogResult = DialogResult.Cancel;
			endButton.Dock = DockStyle.Bottom;
			endButton.Location = new Point(10, 32);
			endButton.Name = "endButton";
			endButton.Size = new Size(141, 30);
			endButton.TabIndex = 1;
			endButton.Text = "Выйти";
			endButton.UseVisualStyleBackColor = true;
			endButton.Click += endButton_Click;
			// 
			// restartButton
			// 
			restartButton.DialogResult = DialogResult.Retry;
			restartButton.Dock = DockStyle.Bottom;
			restartButton.Location = new Point(10, 62);
			restartButton.Name = "restartButton";
			restartButton.Size = new Size(141, 30);
			restartButton.TabIndex = 0;
			restartButton.Text = "Заново";
			restartButton.UseVisualStyleBackColor = true;
			restartButton.Click += restartButton_Click;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(161, 40);
			label1.TabIndex = 0;
			label1.Text = "Конец";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// fullDock
			// 
			fullDock.Controls.Add(timeLabel);
			fullDock.Dock = DockStyle.Fill;
			fullDock.Location = new Point(161, 0);
			fullDock.Name = "fullDock";
			fullDock.Padding = new Padding(5);
			fullDock.Size = new Size(295, 142);
			fullDock.TabIndex = 1;
			// 
			// timeLabel
			// 
			timeLabel.Dock = DockStyle.Top;
			timeLabel.Location = new Point(5, 5);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(285, 40);
			timeLabel.TabIndex = 0;
			timeLabel.Text = "Время:";
			timeLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dontQuitTimer
			// 
			dontQuitTimer.Enabled = true;
			dontQuitTimer.Interval = 500;
			dontQuitTimer.Tick += dontQuitTimer_Tick;
			// 
			// GameOverControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(fullDock);
			Controls.Add(leftPanel);
			Name = "GameOverControl";
			Size = new Size(456, 142);
			Load += GameOverControl_Load;
			leftPanel.ResumeLayout(false);
			buttonsPanel.ResumeLayout(false);
			fullDock.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel leftPanel;
		private Label label1;
		private Panel fullDock;
		private Label timeLabel;
		private Panel buttonsPanel;
		private Button restartButton;
		private Button endButton;
		private System.Windows.Forms.Timer dontQuitTimer;
	}
}
