using Newtonsoft.Json;

namespace libFootballData.team {
	[JsonObject("team")]
	public class Team {
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("country")]
		public string? Country { get; set; }

		[JsonProperty("founded")]
		public int? Founded { get; set; }

		[JsonProperty("logo")]
		public string? Logo { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("national")]
		public bool? National { get; set; }

	}
}
