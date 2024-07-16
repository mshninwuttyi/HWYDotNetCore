using HWYDotNetCore.MvcChartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MvcChartApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult BarChart()
        {
            BarChartModel model = new BarChartModel();
            model.Labels = new List<string>()
            {
                "South Korea",
                "Canada",
                "United Kingdom",
                "Netherlands",
                "Italy",
                "France",
                "Japan",
                "United States",
                "China",
                "Germany"
            };
            model.Series = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            return View(model);
        }
    }
}
