using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProject.Database;
using WebProject.Services;

namespace WebProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public CommandsService CommandService;
        public AliasesService AliasesService;
        public PagerService PagerService;
        public List<ChannelCommands> Commands { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            CommandsService commandService,
            AliasesService aliasesService,
            PagerService pagerService)
        {
            _logger = logger;
            CommandService = commandService;
            AliasesService = aliasesService;
            PagerService = pagerService;
        }

        public void OnGet()
        {

        }
    }
}