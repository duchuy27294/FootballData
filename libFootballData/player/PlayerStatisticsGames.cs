using Newtonsoft.Json;

namespace libFootballData.player
{
    public class PlayerStatisticsGames
    {
        [JsonProperty("appearences")]
        public int Appearences { get; set; }

        [JsonProperty("lineups")]
        public int Lineups { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("rating")]
        public string? Rating { get; set; }


    }
}
