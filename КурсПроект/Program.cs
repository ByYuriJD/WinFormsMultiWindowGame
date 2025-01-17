namespace КурсПроект {
	internal static class Program {

		static Main main = null;
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			main = new Main();

			main.FormClosing += gameFinished;
			Application.Run(main);
		}
		public static void gameFinished(object sender, EventArgs e) {
			if (main.DialogResult == DialogResult.Retry) {
				startGame();
				Application.Exit();
				Application.Restart();
				main = null;
			}
		}
		private static void startGame() {
			if (main != null) 
				main.Dispose();
			main = new Main();
			main.FormClosing += gameFinished;

			if (main != null) {
				Application.Exit();
			}
		}
	}
}