using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.ComponentModel.Design;
using System.Threading.Channels;
using WebProject.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebProject.Services
{
	public class AliasesService
	{
		public AliasesService(IWebHostEnvironment webHostEnviornment)
		{
			webHostEnviornment = webHostEnviornment;
		}

		public IWebHostEnvironment webHostEnvironment { get; }

		public List<Aliases> GetAliases(string channel, int commandId)
		{
			using (var context = new PyRZyDB())
			{
				var Aliases = context.Aliases.Where(x => x.Channel == channel && x.CommandId == commandId).OrderBy(x => x.Alias).ToList();
				return Aliases;
			}
		}
		public void AddAlias(string channel, int commandId, string alias)
		{
			using (var context = new PyRZyDB())
			{
				var Alias = new Aliases(commandId, alias, channel);
				context.Aliases.Add(Alias);
				context.SaveChanges();
			}
		}
		public void DeleteAlias(string channel, int aliasId)
		{
			using (var context = new PyRZyDB())
			{
				var Alias = context.Aliases.FirstOrDefault(x => x.Channel == channel && x.Id == aliasId);
				if (Alias != null)
				{
					context.Aliases.Remove(Alias);
					context.SaveChanges();
				}
			}
		}
	}
}
