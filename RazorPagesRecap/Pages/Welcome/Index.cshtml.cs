using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesRecap.Pages.Welcome
{
    public class IndexModel : PageModel
    {
        public string Municipality { get; set; }
        public void OnGet(string municipality)
        {
            Municipality = municipality;
        }
    }
}
