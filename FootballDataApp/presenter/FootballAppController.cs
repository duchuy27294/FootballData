using HuyPham.Football;
using HuyPham.Football.FootballLeague;
using HuyPham.FootballDataApp.View;
using HuyPham.Football.FootballPlayer;

namespace HuyPham.FootballDataApp.Presenter {
	public class FootballAppController {
		private FootballData model;
		private FootballAppGui view;
		private int currentIndex;
		private List<ResponsePlayer>? responsePlayer;

		public FootballAppController(FootballData model, FootballAppGui view) {
			this.model = model;
			this.view = view;
			this.currentIndex = 0;
		}

		public void RegisterEvents() {
			this.view.BtnSearch.Click += this.search;
			this.view.BtnNext.Click += this.next;
			this.view.BtnPrevious.Click += this.previous;
		}

		private void search(object? sender, EventArgs e) {
			this.model.ApiKey = this.view.TbApiKey.Text;

			List<ResponseLeague> respLeague = this.model.SearchLeague(this.view.TbLeagueSearch.Text, this.view.TbCountrySearch.Text);
			if (respLeague.Count == 0) return;
			League? league = respLeague[0].League;
			DateTime dateTime = DateTime.Now;
			int year = (dateTime.Month < 8) ? (dateTime.Year - 1) : dateTime.Year; 
			this.responsePlayer = this.model.SearchPlayerByLeague(this.view.TbNameSearch.Text, league.Id, year);
			if (this.responsePlayer.Count == 0) return;

			this.currentIndex = 0;
			this.view.LblResult.Text = "Result: Player 1 of " + this.responsePlayer.Count.ToString();

			this.fillPlayerInfo(this.responsePlayer[this.currentIndex]);
		}

		private void next(object? sender, EventArgs e) {
			if ( (this.responsePlayer.Count == 0) || (this.responsePlayer == null) ) return;
			this.currentIndex += 1;
			if (this.currentIndex == this.responsePlayer.Count) {
				this.currentIndex = 0;
			}

			this.view.LblResult.Text = "Result: Player " + (this.currentIndex + 1).ToString() + " of " + this.responsePlayer.Count.ToString();

			this.fillPlayerInfo(this.responsePlayer[this.currentIndex]);
		}

		private void previous(object? sender, EventArgs e) {
			if ( (this.responsePlayer.Count == 0) || (this.responsePlayer == null) ) return;
			this.currentIndex -= 1;
			if (this.currentIndex < 0) {
				this.currentIndex = this.responsePlayer.Count - 1;
			}

			this.view.LblResult.Text = "Result: Player " + (this.currentIndex + 1).ToString() + " of " + this.responsePlayer.Count.ToString();

			this.fillPlayerInfo(this.responsePlayer[this.currentIndex]);
		}

		private void fillPlayerInfo(ResponsePlayer responsePlayer) {
			if (responsePlayer.Player.Photo != null) { 				
				this.view.PbPhoto.Load(responsePlayer.Player.Photo);
			}
			else{
				this.view.PbPhoto.Image.Dispose();
				this.view.PbPhoto.Image = null;
			}

			this.view.TbName.Text = (responsePlayer.Player.Name == null) ? "" : responsePlayer.Player.Name;

			this.view.TbFirstName.Text = (responsePlayer.Player.FirstName == null) ? "" : responsePlayer.Player.FirstName;

			this.view.TbLastName.Text = (responsePlayer.Player.LastName == null) ? "" : responsePlayer.Player.LastName;

			this.view.TbAge.Text = (responsePlayer.Player.Age == null) ? "" : responsePlayer.Player.Age.ToString();

			this.view.TbNationality.Text = (responsePlayer.Player.Nationality == null) ? "" : responsePlayer.Player.Nationality;

			if (responsePlayer.Player.Injured) {
				this.view.TbInjured.Text = "true";
			}
			else {
				this.view.TbInjured.Text = "false";
			}

			this.view.TbTeam.Text = (responsePlayer.Statistics[0].Team.Name == null) ? "" : responsePlayer.Statistics[0].Team.Name;

			this.view.TbLeague.Text = (responsePlayer.Statistics[0].League.Name == null) ? "" : responsePlayer.Statistics[0].League.Name;
		}
	}
}
