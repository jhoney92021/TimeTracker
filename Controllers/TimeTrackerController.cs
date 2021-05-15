using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;//TO USE SESSION
using time_tracker.Models;
using time_tracker.DataBase;

namespace time_tracker.Controllers
{
    public class TimeTrackerHomeController : Controller
    {
        private readonly ILogger<TimeTrackerHomeController> _logger;
        private DataBaseContext _DataBaseContext;

        public TimeTrackerHomeController(DataBaseContext DataBaseContext, ILogger<TimeTrackerHomeController> logger)
        {
            _DataBaseContext = DataBaseContext;
            _logger = logger;
        }

        [HttpGet("TimeTracker")]
        public IActionResult Index()
        {
            //int? validActiveUserId = HttpContext.Session.GetInt32("validActiveUser");
            return View();
        }       


        [HttpGet("TimeTracker/TimeEntry")]
        public IActionResult TimeEntry()
        {
            //int? validActiveUserId = HttpContext.Session.GetInt32("validActiveUser");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
