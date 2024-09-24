using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorASP.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentDate { get; set; } = DateTime.Now.ToString();
        public void OnGet()
        {
            ViewData["Title"] = "Дубины и сандали!";
        }
    }
}
