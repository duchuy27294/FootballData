using Newtonsoft.Json;

namespace HuyPham.Football.FootballCountry {
	public class ResponseCountry {

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("flag")]
		public string? Flag { get; set; }
	}
}
