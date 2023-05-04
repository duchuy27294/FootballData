using Newtonsoft.Json;

namespace libFootballData.player
{
    public class Player
    {

		[JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstname")]
        public string? FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("photo")]
        public string? Photo { get; set; }

        [JsonProperty("height")]
		public string? Height { get; set; }

        [JsonProperty("weight")]
		public string? Weight { get; set; }

        [JsonProperty("injured")]
		public bool Injured { get; set; }
	}
}
