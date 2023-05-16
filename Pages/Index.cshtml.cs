using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using uwierzytelnianieClaimsIdentity.Data;
using uwierzytelnianieClaimsIdentity.Models;
namespace uwierzytelnianieClaimsIdentity.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public Search search = new Search();
		
		//blad jakis
		public DbContextOptions options
        public SearchContext searchContext = new SearchContext();

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
		public IActionResult OnPost() 
		{
			if (search != null)
			{
				ViewData["message"] = "elo";
			}
            searchContext.Search.Add(search);
            searchContext.SaveChanges();

            return RedirectToPage("./Index");

        }
	}
}