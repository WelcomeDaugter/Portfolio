using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class AchivementsModel : PageModel
    {
        private readonly ILogger<AchivementsModel> _logger;

        public AchivementsModel(ILogger<AchivementsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}