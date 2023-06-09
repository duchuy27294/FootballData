﻿using Newtonsoft.Json;

namespace HuyPham.Football.FootballLeague {
	[JsonObject("country")]
	public class LeagueCountry {
		[JsonProperty("name")]
		public string? Name { get; set; }

		[JsonProperty("code")]
		public string? Code { get; set; }

		[JsonProperty("flag")]
		public string? Flag { get; set; }
	}
}
