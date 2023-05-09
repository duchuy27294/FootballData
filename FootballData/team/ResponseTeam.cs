using Newtonsoft.Json;

namespace HuyPham.Football.FootballTeam {

	[JsonObject("response")]
	public class ResponseTeam {

		[JsonProperty("team")]
		public Team Team { get; set; }
	}
}
