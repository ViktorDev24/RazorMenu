using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMenu.Pages.Shared;

namespace RazorMenu.Pages
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
        }

        public List<ChartData> ChartDataSource { get; set; }

        public ChartModel ChartModel { get; set; }
        public void OnGet()
        {
            ChartDataSource = new List<ChartData>
            {
                new ChartData { Month = "Jan", Apple = 5, Orange = 5, Wastage = -1 },
                new ChartData { Month = "Feb", Apple = 6, Orange = 7, Wastage = -2 },
                new ChartData { Month = "Mar", Apple = 11, Orange = 10, Wastage = -3 },
                new ChartData { Month = "Apr", Apple = 15, Orange = 15, Wastage = -4 },
                new ChartData { Month = "May", Apple = 19, Orange = 25, Wastage = -5 },
                new ChartData { Month = "Jun", Apple = 21, Orange = 23, Wastage = -6 },
            };
            ChartModel = new ChartModel
            {
                ChartDataSource = ChartDataSource
            };
        }
    }
}