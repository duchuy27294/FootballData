using libFootballData.league;
using Newtonsoft.Json;

namespace libFootballData.league {
	public class ResponseLeague {
		[JsonProperty("league")]
		public League League { get; set; }

		[JsonProperty("country")]
		public LeagueCountry Country { get; set; }

		[JsonProperty("seasons")]
		public List<LeagueSeason> Seasons { get; set; }
		
	}
}
