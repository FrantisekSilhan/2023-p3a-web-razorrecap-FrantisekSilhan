using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.InputModels;

namespace RazorPagesRecap.Pages.Survey
{
    public class IndexModel : PageModel
    {
        public FormIM formIM { get; set; }
        public void OnGet()
        {
        }
    }
}
