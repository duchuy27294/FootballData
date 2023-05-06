using System.Net.Http;
using System.Net.Http.Headers;
using libFootballData.team;
using Newtonsoft.Json;
using System.Text.Json;
using libFootballData.player;
using libFootballData.league;
using System.Xml.Linq;
using libFootballData.country;

namespace libFootballData {
	public class FootballData {
		private string? apiKey;
		private static readonly string apiKeyHeaderKey = "X-RapidAPI-Key";
		private static readonly string apiHostHeaderKey = "X-RapidAPI-Host";
		private static readonly string apiHostHeaderValue = "api-football-v1.p.rapidapi.com";
		private static readonly string apiHost = "https://api-football-v1.p.rapidapi.com";
		private static readonly string pathPlayer = "/v3/players";
		private static readonly string pathLeague = "/v3/leagues";
		private static readonly string pathCountry = "/v3/countries";
		private static readonly string pathTeam = "/v3/teams";
		private HttpClient client;
		private HttpRequestMessage request;
		private HttpResponseMessage? response;
		private UriBuilder builder;
		private string? jsonResponseStr;

		public FootballData() {
			this.client = new HttpClient();

			this.request = new HttpRequestMessage();
			this.request.Method = HttpMethod.Get;
			this.request.Content?.Headers.Add("Content-Type", "application/json");
			//this.request.Headers.Add(FootballData.apiKeyHeaderKey, apiKey);
			this.request.Headers.Add(FootballData.apiHostHeaderKey, FootballData.apiHostHeaderValue);

			this.builder = new UriBuilder(apiHost);
		}

		public FootballData(string apiKey) {
			this.apiKey = apiKey;
			this.client = new HttpClient();

			this.request = new HttpRequestMessage();
			this.request.Method = HttpMethod.Get;
			this.request.Content?.Headers.Add("Content-Type", "application/json");
			this.request.Headers.Add(FootballData.apiKeyHeaderKey, apiKey);
			this.request.Headers.Add(FootballData.apiHostHeaderKey, FootballData.apiHostHeaderValue);

			this.builder = new UriBuilder(apiHost);
		}

		public string? ApiKey {
			get {
				return this.apiKey;
			}
			set {
				this.apiKey = value;
				if (this.request.Headers.Contains(FootballData.apiKeyHeaderKey)) {
					
					this.request.Headers.Remove(FootballData.apiKeyHeaderKey);
				}
				this.request.Headers.Add(FootballData.apiKeyHeaderKey, apiKey);
			}
		}

		public List<ResponseTeam>? SearchTeam(string searchStr) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathTeam;

			string modifiedStr = searchStr;
			if (modifiedStr.Contains(" ")) {
				modifiedStr.Replace(" ", "%%20");
			}

			this.builder.Query += "search=" + modifiedStr;

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<List<ResponseTeam>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseTeam>? SearchTeamByExactName(string name) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathTeam;

			string modifiedStr = name;
			if (modifiedStr.Contains(" ")) {
				modifiedStr.Replace(" ", "%%20");
			}

			this.builder.Query += "name=" + modifiedStr;

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<List<ResponseTeam>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponsePlayer>? SearchPlayerByLeague(string name, int league) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathPlayer;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "search=" + modifiedName;
			this.builder.Query += "&league=" + league.ToString();

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponsePlayer>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponsePlayer>? SearchPlayerByTeam(string name, int team) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathPlayer;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "search=" + modifiedName;
			this.builder.Query += "&team=" + team.ToString();

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponsePlayer>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseLeague>? SearchLeague(string name, string country) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "name=" + modifiedName;

			if (country.Length > 0) {
				string modifiedCountry = country;
				if (modifiedCountry.Contains(" ")) {
					modifiedCountry.Replace(" ", "%%20");
				}
				this.builder.Query += "&country=" + modifiedCountry;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseLeague>? SearchLeague(string name, string country = "", string type = "") {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "name=" + modifiedName;

			if (country.Length > 0) {
				string modifiedCountry = country;
				if (modifiedCountry.Contains(" ")) {
					modifiedCountry.Replace(" ", "%%20");
				}
				this.builder.Query += "&country=" + modifiedCountry;
			}

			if (type.Length > 0) {
				this.builder.Query += "&type=" + type;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseLeague>? SearchLeague(string name, int season, string country = "", string type = "") {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "name=" + modifiedName;

			this.builder.Query += "&season=" + season.ToString();

			if (country.Length > 0) {
				string modifiedCountry = country;
				if (modifiedCountry.Contains(" ")) {
					modifiedCountry.Replace(" ", "%%20");
				}
				this.builder.Query += "&country=" + modifiedCountry;
			}

			if (type.Length > 0) {
				this.builder.Query += "&type=" + type;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseLeague>? SearchLeague(string name, bool current, string country = "", string type = "") {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedName = name;
			if (modifiedName.Contains(" ")) {
				modifiedName.Replace(" ", "%%20");
			}

			this.builder.Query += "name=" + modifiedName;

			if (current) {
				this.builder.Query += "&current=true";
			}
			else {
				this.builder.Query += "&current=false";
			}

			if (country.Length > 0) {
				string modifiedCountry = country;
				if (modifiedCountry.Contains(" ")) {
					modifiedCountry.Replace(" ", "%%20");
				}
				this.builder.Query += "&country=" + modifiedCountry;
			}

			if (type.Length > 0) {
				this.builder.Query += "&type=" + type;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		//public List<ResponseLeague>? SearchLeague(string country, string type = "") {
		//	this.builder.Query = string.Empty;
		//	this.builder.Path = FootballData.pathLeague;

		//	string modifiedCountry = country;
		//	if (modifiedCountry.Contains(" ")) {
		//		modifiedCountry.Replace(" ", "%%20");
		//	}
		//	this.builder.Query += "country=" + modifiedCountry;

		//	if (type.Length > 0) {
		//		this.builder.Query += "&type=" + type;
		//	}

		//	this.request.RequestUri = this.builder.Uri;

		//	this.response = this.client.SendAsync(this.request).Result;
		//	this.response.EnsureSuccessStatusCode();
		//	this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

		//	return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		//}

		public List<ResponseLeague>? SearchLeague(string country, int season, string type = "") {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedCountry = country;
			if (modifiedCountry.Contains(" ")) {
				modifiedCountry.Replace(" ", "%%20");
			}
			this.builder.Query += "country=" + modifiedCountry;

			this.builder.Query += "&season=" + season.ToString();

			if (type.Length > 0) {
				this.builder.Query += "&type=" + type;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseLeague>? SearchLeague(string country, bool current, string type = "") {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedCountry = country;
			if (modifiedCountry.Contains(" ")) {
				modifiedCountry.Replace(" ", "%%20");
			}
			this.builder.Query += "&country=" + modifiedCountry;

			if (current) {
				this.builder.Query += "&current=true";
			}
			else {
				this.builder.Query += "&current=false";
			}

			if (type.Length > 0) {
				this.builder.Query += "&type=" + type;
			}

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseLeague>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

		public List<ResponseCountry>? SearchCountry(string search) {
			this.builder.Query = string.Empty;
			this.builder.Path = FootballData.pathLeague;

			string modifiedSearch = search;
			if (modifiedSearch.Contains(" ")) {
				modifiedSearch.Replace(" ", "%%20");
			}
			this.builder.Query += "&search=" + modifiedSearch;

			this.request.RequestUri = this.builder.Uri;

			this.response = this.client.SendAsync(this.request).Result;
			this.response.EnsureSuccessStatusCode();
			this.jsonResponseStr = response.Content.ReadAsStringAsync().Result;

			return JsonConvert.DeserializeObject<List<ResponseCountry>>(JsonDocument.Parse(jsonResponseStr).RootElement.GetProperty("response").GetRawText());
		}

	}
}