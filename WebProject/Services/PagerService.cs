namespace WebProject.Services
{
	public class PagerService
	{
		public PagerService(IWebHostEnvironment webHostEnviornment)
		{
			webHostEnviornment = webHostEnviornment;
		}
		public IWebHostEnvironment webHostEnvironment { get; }

		public PagerService(int pageSize, int totalEntries)
		{
			CurrentPage = 1;
			PageSize = pageSize;
			TotalPages = (int)Math.Ceiling((float)totalEntries / (float)pageSize);
			TotalEntries = totalEntries;
		}
		public int CurrentPage { get; set; }
		public int PageSize { get; set; }
		public int TotalPages { get; set; }
		public int TotalEntries { get; set; }

		public void SetPageSize(PagerService pager, int size)
		{
			pager.PageSize = size;
			pager.CurrentPage = 1;
			pager.TotalPages = (int)Math.Ceiling((float)pager.TotalEntries / (float)pager.PageSize);
		}
		public void ChangePage(PagerService pager, int direction)
		{
			switch (direction)
			{
				case 1:
					{
						if (pager.CurrentPage < pager.TotalPages)
							pager.CurrentPage++;
					}
					break;

				case -1:
					{
						if (pager.CurrentPage > 1)
							pager.CurrentPage--;
					}
					break;

				default:
					{

					}
					break;
			}
		}
	}
}
