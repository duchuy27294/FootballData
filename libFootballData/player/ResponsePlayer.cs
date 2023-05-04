using libFootballData.player;
using Newtonsoft.Json;

namespace libFootballData.player {
	public class ResponsePlayer {
		[JsonProperty("player")]
		public Player? Player { get; set; }

		[JsonProperty("statistics")]
		public List<PlayerStatistics>? Statistics { get; set; }
	}
}
