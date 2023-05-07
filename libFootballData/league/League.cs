﻿using Newtonsoft.Json;

namespace libFootballData.league {
	[JsonObject("league")]
	public class League {

		[JsonProperty("id")]
		public int? Id { get; set;}

		[JsonProperty("name")]
		public string? Name { get; set; }

		[JsonProperty("type")]
		public string? Type { get; set; }

		[JsonProperty("logo")]
		public string? Logo { get; set; }
	}
}
