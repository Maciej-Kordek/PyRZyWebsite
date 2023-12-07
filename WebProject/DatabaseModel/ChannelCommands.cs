namespace WebProject.Database
{
	public class ChannelCommands
	{
		public ChannelCommands() { }
		public ChannelCommands(string commandname, string response, string channel,
			int cooldown = 3, string gameSpecific = "",
			int accessLevel = 2, int editLevel = 5 )//Default Constructor
		{
			CommandName = commandname;
			Response = response;
			AccessLevel = accessLevel;
			Timer = 0;
			TimesUsed = 0;
			Cooldown = cooldown;
			LastUsed = DateTime.Now.AddDays(-1);
			Channel = channel;
			GameSpecific = gameSpecific;
			IsEnabled = true;
			IsComplex = false;
			ToDisplay = true;
			EditLevel = editLevel;
			ParentCommand = 0;
			Deletable = true;
		}
	//	public ChannelCommands(string commandname, string response, string channel,
	//int cooldown = 3, string gameSpecific = "", int timer = 60,
	//int accessLevel = 2, int editLevel = 5)//Timed Constructor
	//	{
	//		CommandName = commandname;
	//		Response = response;
	//		AccessLevel = accessLevel;
	//		Timer = timer;
	//		TimesUsed = 0;
	//		Cooldown = cooldown;
	//		LastUsed = DateTime.Now.AddDays(-1);
	//		Channel = channel;
	//		GameSpecific = gameSpecific;
	//		IsEnabled = true;
	//		IsComplex = false;
	//		ToDisplay = true;
	//		EditLevel = editLevel;
	//		ParentCommand = 0;
	//		Deletable = true;
	//	}

		public int Id { get; set; }
		public string CommandName { get; set; }
		public string Response { get; set; }
		public int AccessLevel { get; set; }
		public int Timer { get; set; }
		public int TimesUsed { get; set; }
		public int Cooldown { get; set; }
		public DateTime LastUsed { get; set; }
		public string Channel { get; set; }
		public string GameSpecific { get; set; }
		public bool IsEnabled { get; set; }
		public bool IsComplex { get; set; }
		public bool ToDisplay { get; set; }
		public int ParentCommand { get; set; }
		public int EditLevel { get; set; }
		public bool Deletable { get; set; }

		public List<Aliases> Aliases { get; set; }
	}
}
