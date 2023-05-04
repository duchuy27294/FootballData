using Newtonsoft.Json;

namespace libFootballData.league {
	[JsonObject("seasons")]
	public class LeagueSeason {

		[JsonProperty("year")]
		public int Year { get; set; }

		[JsonProperty("start")]
		public string Start { get; set; }

		[JsonProperty("end")]
		public string End { get; set; }

		[JsonProperty("current")]
		public bool Current { get; set; }
	}
}
