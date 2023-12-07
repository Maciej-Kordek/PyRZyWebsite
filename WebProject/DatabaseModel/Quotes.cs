namespace WebProject.Database
{
	public class Quotes
	{
		public Quotes() { }
		public Quotes(string quote, string channel)
		{
			Quote = quote;
			Channel = channel;
		}

		public int Id { get; set; }
		public string Quote { get; set; }
		public string Channel { get; set; }

	}
}
