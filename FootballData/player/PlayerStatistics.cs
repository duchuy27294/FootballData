using Newtonsoft.Json;

namespace HuyPham.Football.FootballPlayer {
    public class PlayerStatistics
    {

        [JsonProperty("team")]
        public PlayerStatisticsTeam? Team { get; set; }

        [JsonProperty("league")]
        public PlayerStatisticsLeague? League { get; set; }

        [JsonProperty("games")]
        public PlayerStatisticsGames? Games { get; set; }
    }
}
