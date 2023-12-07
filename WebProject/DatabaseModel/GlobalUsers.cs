namespace WebProject.Database
{
	public class GlobalUsers
	{
		public GlobalUsers() { }
		public GlobalUsers(int twitchid, string name)
		{
			TwitchId = twitchid;
			Name = name;

			DuelsPlayed = 0;
			DuelsWon = 0;
			MaxDuelBet = -1;
			AcceptsDuels = true;
			ToRank = true;

		}

		public int Id { get; set; }
		public int TwitchId { get; set; }
		public string Name { get; set; }

		public int DuelsPlayed { get; set; }
		public int DuelsWon { get; set; }
		public int MaxDuelBet { get; set; }
		public bool AcceptsDuels { get; set; }
		public bool ToRank { get; set; }

		public List<ChatUsers> ChatUsers { get; set; }
	}
}
