namespace WebProject.Database
{
	public class ChannelInfo
	{
		public ChannelInfo() { }
		public ChannelInfo(string name, string twitchid)
		{
			Channel = name;
			ChannelId = twitchid;
			Token = string.Empty;
			ClientId = string.Empty;
			Language = string.Empty;
			BotColor = string.Empty;
			CommandSymbol = '!';
			ChatFeedback = 0;
			BotProtection = 0;
			IsStreaming = false;

			PointsName = "Points";
			RedeemOn = string.Empty;
			DuelsPlayed = 0;
			AttackersWin = 0;
			DefendersWin = 0;

			Game = string.Empty;
			Title = string.Empty;
			NextGame = string.Empty;
			NextTitle = string.Empty;
		}


		public int Id { get; set; }
		public string Channel { get; set; }
		public string ChannelId { get; set; }
		public string Token { get; set; }
		public string ClientId { get; set; }
		public string Language { get; set; }
		public string BotColor { get; set; }
		public char CommandSymbol { get; set; }
		public int ChatFeedback { get; set; }
		public int BotProtection { get; set; }
		public bool IsStreaming { get; set; }


		public string PointsName { get; set; }
		public string RedeemOn { get; set; }
		public int DuelsPlayed { get; set; }
		public int AttackersWin { get; set; }
		public int DefendersWin { get; set; }

		public string Game { get; set; }
		public string Title { get; set; }
		public string NextGame { get; set; }
		public string NextTitle { get; set; }

		public List<ChannelLinks> ChannelLinks { get; set; }
	}
}
