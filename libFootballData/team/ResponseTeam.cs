using Newtonsoft.Json;

namespace libFootballData.team {

	[JsonObject("response")]
	public class ResponseTeam {

		[JsonProperty("team")]
		public Team Team { get; set; }
	}
}
