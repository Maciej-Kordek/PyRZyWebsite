namespace WebProject.Database
{
	public class Aliases
	{
		public Aliases() { }
		public Aliases(int commandid, string alias, string channel)
		{
			CommandId = commandid;
			Alias = alias;
			Channel = channel;
		}

		public int Id { get; set; }
		public int CommandId { get; set; }
		public string Alias { get; set; }
		public string Channel { get; set; }

		public ChannelCommands ChannelCommands { get; set; }
	}
}
