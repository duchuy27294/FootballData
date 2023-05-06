using FootballDataApp.presenter;
using FootballDataApp.view;
using libFootballData;

namespace FootballDataApp {
	public class Program {

		public Program() {
			ApplicationConfiguration.Initialize();
			FootballData model = new FootballData();
			FootballAppGui view = new FootballAppGui();
			FootballAppController controller = new FootballAppController(model, view);
			controller.RegisterEvents();
			Application.Run(view);
		}

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			//ApplicationConfiguration.Initialize();
			//Application.Run(new FootballAppGui());
			new Program();
		}
	}
}