namespace КурсПроект {
	internal static class Program {

		static Main main = null;
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			main = new Main();

			Application.Run(main);
		}
	}
}