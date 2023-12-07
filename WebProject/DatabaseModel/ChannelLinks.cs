namespace WebProject.Database
{
	public class ChannelLinks
	{
		public ChannelLinks() { }
		public ChannelLinks(string twitchid, string name)
		{
			LinkRequesterId = twitchid;
			LinkRequesterName = name;
			//Finish
			Linked = false;
		}

		public int Id { get; set; }
		public string LinkRequesterId { get; set; }
		public string LinkRequesterName { get; set; }
		public string LinkTargetId { get; set; }
		public string LinkTargetName { get; set; }
		public bool Linked { get; set; }

		public ChannelInfo ChannelInfo { get; set; }
	}
}
