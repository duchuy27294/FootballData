using HuyPham.Football.FootballPlayer;
using HuyPham.Football;

namespace HuyPham.TestProject {
	public class FootballAppTest {
		private FootballData app;
		
		[Fact]
		public void SearchPlayerCasemiro() {
			StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + "\\ApiKey.txt");
			string line = sr.ReadLine();
			sr.Close();
			app = new FootballData();
			app.ApiKey = line;

			List<ResponsePlayer>? responsePlayer = app.SearchPlayerByLeague("casemiro", 39);
			Assert.Equal("Casemiro", responsePlayer[0].Player.Name);
			Assert.Equal("Brazil", responsePlayer[0].Player.Nationality);
			Assert.Equal(747, responsePlayer[0].Player.Id);
		}
	}
}