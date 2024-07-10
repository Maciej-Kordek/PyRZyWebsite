using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProject.Database;
using WebProject.Services;

namespace WebProject.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private ProtectedSessionStorage _sessionStorage;

		public const string SessionKeyName = "_Name";
		public const string SessionKeyAge = "_Age";

		public CommandsService CommandService;
		public AliasesService AliasesService;
		public PagerService PagerService;
		public TwitchMessageService TwitchMessageService;
		public List<ChannelCommands> Commands { get; private set; }

		public IndexModel(ILogger<IndexModel> logger,
			ProtectedSessionStorage sessionStorage,
			CommandsService commandService,
			AliasesService aliasesService,
			PagerService pagerService,
			TwitchMessageService twitchmessageservice)
		{
			_logger = logger;
			_sessionStorage = sessionStorage;
			CommandService = commandService;
			AliasesService = aliasesService;
			PagerService = pagerService;
			TwitchMessageService = twitchmessageservice;
		}

		public void OnGet()
		{
			if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
			{
				HttpContext.Session.SetString(SessionKeyName, "Guest");
				HttpContext.Session.SetInt32(SessionKeyAge, 0);
			}
		}
	}
}