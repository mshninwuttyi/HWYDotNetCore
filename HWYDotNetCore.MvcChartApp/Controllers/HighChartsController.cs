using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MvcChartApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult SplineChart()
        {
            return View();
        }

        public IActionResult ColumnChart()
        {
            return View();
        }
    }
}
