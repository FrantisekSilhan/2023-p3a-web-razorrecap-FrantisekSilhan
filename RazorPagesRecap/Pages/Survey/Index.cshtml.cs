using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.InputModels;
using System.Collections.Immutable;

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
                return RedirectToPage("/Welcome/Index", new
                {
                    municipality = FormIM.Municipality
                });
            }

            return Page();
        }
    }
}
