using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using WebProject.Database;

namespace WebProject.Services
{
	public class CommandsService
	{
		public CommandsService(IWebHostEnvironment webHostEnviornment)
		{
			webHostEnviornment = webHostEnviornment;
		}

		public IWebHostEnvironment webHostEnvironment { get; }

		public List<ChannelCommands> GetChannelCommands(string channel)
		{
			using (var context = new PyRZyDB())
			{
				var Commands = context.ChannelCommands.Where(x => x.Channel == channel).OrderBy(x => x.CommandName).ToList();
				return Commands;
			}
		}
		public List<ChannelCommands> GetXCommands(string channel, int rowsDisplayed, int currentPage)
		{
			using (var context = new PyRZyDB())
			{
				var Commands = context.ChannelCommands.Where(x => x.Channel == channel)
					.OrderBy(x => x.CommandName)
					.Skip((currentPage - 1) * rowsDisplayed)
					.Take(rowsDisplayed)
					.ToList();
				return Commands;
			}
		}
		public ChannelCommands GetCommand(string channel, int commandId)
		{
			using (var context = new PyRZyDB())
			{
				var Command = context.ChannelCommands.FirstOrDefault(x => x.Channel == channel && x.Id == commandId);
				return Command;
			}
		}
		public ChannelCommands GetTemplateCommand(string channel)
		{
			return new ChannelCommands("", "", channel);
		}
		public int GetCommandsCount(string channel)
		{
			using (var context = new PyRZyDB())
				return context.ChannelCommands.Where(x => x.Channel == channel).ToList().Count;
		}
		public void AddCommand(string channel, ChannelCommands commandModel)
		{
			using (var context = new PyRZyDB())
			{
				//var Command = new ChannelCommands(command.commandName, command.commandValue, command.channel);
				commandModel.Channel = channel;
				context.Add(commandModel);
				context.SaveChanges();
			}
		}
		public void DeleteCommand(int commandId)
		{
			using (var context = new PyRZyDB())
			{
				var command = context.ChannelCommands.FirstOrDefault(x => x.Id == commandId);
				if (command != null)
				{
					context.Remove(command);
					context.SaveChanges();
				}
			}
		}
		public void EditCommand(ChannelCommands commandModel)
		{
			using (var context = new PyRZyDB())
			{
				commandModel.CommandName.ToLower();
				context.Update(commandModel);
				context.SaveChanges();
			}
		}
	}
}
