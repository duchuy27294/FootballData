using libFootballData;
using FootballDataApp.view;

namespace FootballDataApp.presenter {
	public class FootballAppController {
		private FootballData model;
		private FootballAppGui view;

		public FootballAppController(FootballData model, FootballAppGui view) {
			this.model = model;
			this.view = view;
		}

		public void RegisterEvents() {
			this.view.BtnSearch.Click += this.search;
		}

		private void search(object? sender, EventArgs e) {
			
		}
	}
}
