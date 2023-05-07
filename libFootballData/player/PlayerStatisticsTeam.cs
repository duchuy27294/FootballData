using Newtonsoft.Json;

namespace libFootballData.player
{
    public class PlayerStatisticsTeam
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("logo")]
        public string? Logo { get; set; }
    }
}
