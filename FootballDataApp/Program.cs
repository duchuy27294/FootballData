using HuyPham.Football;
using HuyPham.FootballDataApp.View;
using HuyPham.FootballDataApp.Presenter;

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

		[STAThread]
		static void Main() {
			new Program();
		}
	}
}