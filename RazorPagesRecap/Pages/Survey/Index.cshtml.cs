using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.InputModels;

namespace RazorPagesRecap.Pages.Survey
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FormIM FormIM { get; set; } = new FormIM();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }

            return Page();
        }
    }
}
