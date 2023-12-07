namespace WebProject.Database
{
	public class ChatUsers
	{
		public ChatUsers() { }
		public ChatUsers(int twitchid, string name, string channel)
		{
			TwitchId = twitchid;
			Name = name;
			Channel = channel;
			AccessLevel = 2;

			IsWatching = true;
			JoinTime = DateTime.Now;
			Watchtime = 0;
			MessagesSent = 0;

			Points = 1000;
			DuelsPlayed = 0;
			DuelsWon = 0;
			Streak = 0;
			MaxWinStreak = 0;
			MaxLoseStreak = 0;
			DuelId = 0;
			LastDuel = DateTime.MinValue;
		}

		public int Id { get; set; }
		public int TwitchId { get; set; }
		public string Name { get; set; }
		public int AccessLevel { get; set; }
		public string Channel { get; set; }

		public bool IsWatching { get; set; }
		public DateTime JoinTime { get; set; }
		public int Watchtime { get; set; }
		public int MessagesSent { get; set; }

		public int Points { get; set; }
		public int DuelsPlayed { get; set; }
		public int DuelsWon { get; set; }
		public int Streak { get; set; }
		public int MaxWinStreak { get; set; }
		public int MaxLoseStreak { get; set; }
		public int DuelId { get; set; }
		public DateTime LastDuel { get; set; }

		public GlobalUsers GlobalUsers { get; set; }
	}
}
