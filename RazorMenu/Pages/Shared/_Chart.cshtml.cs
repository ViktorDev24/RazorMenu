using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMenu.Pages.Shared
{
    public class ChartModel : PageModel
    {

        public ChartModel()
        {
        }
        public List<ChartData> ChartDataSource { get; set; }
        public void OnGet()
        {
        }
    }
}