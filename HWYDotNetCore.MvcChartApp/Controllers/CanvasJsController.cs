using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MvcChartApp.Controllers
{
    public class CanvasJsController : Controller
    {
        public IActionResult LineChart()
        {
            return View();
        }

        public IActionResult ZoomAndPlanChart()
        {
            return View();
        }

        public IActionResult ColumnChart()
        {
            return View();
        }
    }
}
