using Newtonsoft.Json;

namespace HuyPham.Football.FootballPlayer {
	public class ResponsePlayer {
		[JsonProperty("player")]
		public Player? Player { get; set; }

		[JsonProperty("statistics")]
		public List<PlayerStatistics>? Statistics { get; set; }
	}
}
