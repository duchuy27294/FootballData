using libFootballData;
using libFootballData.league;
using FootballDataApp.view;
using libFootballData.player;

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
			this.model.ApiKey = this.view.TbApiKey.Text;

			List<ResponseLeague> respLeague = this.model.SearchLeague(this.view.TbLeagueSearch.Text, this.view.TbCountrySearch.Text);
			if (respLeague.Capacity == 0) return;
			League league = respLeague[0].League;
			List<ResponsePlayer>? respPlayer = this.model.SearchPlayerByLeague(this.view.TbNameSearch.Text, league.Id);
			if (respPlayer.Capacity == 0) return;

			Player player = respPlayer[0].Player;

			this.view.PbPhoto.Load(player.Photo);
			this.view.TbName.Text = player.Name;
			this.view.TbFirstName.Text = player.FirstName;
			this.view.TbLastName.Text = player.LastName;
			this.view.TbAge.Text = player.Age.ToString();
			this.view.TbNationality.Text = player.Nationality;
			if (player.Injured) {
				this.view.TbInjured.Text = "true";
			}
			else {
				this.view.TbInjured.Text = "false";
			}
			this.view.TbTeam.Text = respPlayer[0].Statistics[0].Team.Name;
			this.view.TbLeague.Text = respPlayer[0].Statistics[0].League.Name;
		}
	}
}
