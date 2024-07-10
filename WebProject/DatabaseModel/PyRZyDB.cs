using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace WebProject.Database
{
	public class PyRZyDB : DbContext
	{
		private string _ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=PyRZyDB;Trusted_Connection=true;";

		public DbSet<ChannelInfo> ChannelInfo { get; set; }
		public DbSet<ChannelLinks> ChannelLinks { get; set; }

		public DbSet<ChatUsers> ChatUsers { get; set; }
		public DbSet<GlobalUsers> GlobalUsers { get; set; }

		public DbSet<ChannelCommands> ChannelCommands { get; set; }
		public DbSet<Aliases> Aliases { get; set; }

		public DbSet<Quotes> Quotes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ChatUsers>()
				.HasOne(x => x.GlobalUsers)
				.WithMany(x => x.ChatUsers)
				.HasForeignKey(x => x.TwitchId)
				.HasPrincipalKey(x => x.TwitchId);

			modelBuilder.Entity<ChannelCommands>()
				.ToTable(x => x.HasTrigger("OnIn/Up"))
				.HasMany(x => x.Aliases)
				.WithOne(x => x.ChannelCommands)
				.HasForeignKey(x => x.CommandId)
				.HasPrincipalKey(x => x.Id)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<ChannelInfo>()
				.HasMany(x => x.ChannelLinks)
				.WithOne(x => x.ChannelInfo)
				.HasForeignKey(x => x.LinkRequesterId)
				.HasPrincipalKey(x => x.ChannelId);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_ConnectionString);
		}
	}
}
