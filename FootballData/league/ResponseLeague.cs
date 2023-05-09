using HuyPham.Football.FootballPlayer;
using Newtonsoft.Json;

namespace HuyPham.Football.FootballLeague {
	public class ResponseLeague {
		[JsonProperty("league")]
		public League? League { get; set; }

		[JsonProperty("country")]
		public LeagueCountry? Country { get; set; }

		[JsonProperty("seasons")]
		public List<LeagueSeason>? Seasons { get; set; }
		
	}
}
