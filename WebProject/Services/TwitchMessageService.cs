using System.Net.Sockets;
using System.Threading.Channels;
using WebProject;

namespace WebProject.Services
{
	public class TwitchMessageService
	{
		public TwitchMessageService(IWebHostEnvironment webHostEnviornment)
		{
			webHostEnviornment = webHostEnviornment;
		}
		public IWebHostEnvironment webHostEnvironment { get; }

		public async Task SendMessage(string channel, string message)
		{
			string ip = "irc.chat.twitch.tv";
			int port = 6667;
            string token = $"oauth:{BotInfo.oauth}";
			string botName = "PyRZyBot";

			var tcpClient = new TcpClient();
			await tcpClient.ConnectAsync(ip,port);
			var streamWriter = new StreamWriter(tcpClient.GetStream()) { NewLine = "\r\n", AutoFlush = true};

			await streamWriter.WriteLineAsync($"PASS {token}");
			await streamWriter.WriteLineAsync($"NICK {botName}");

			await streamWriter.WriteLineAsync($"PRIVMSG #{channel} :{message}");
		}

	}
}
