﻿using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MvcChartApp.Controllers
{
    public class CanvasJsController : Controller
    {
        private readonly ILogger<CanvasJsController> _logger;

        public CanvasJsController(ILogger<CanvasJsController> logger)
        {
            _logger = logger;
        }

        public IActionResult LineChart()
        {
            _logger.LogInformation("Line Chart...");
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
