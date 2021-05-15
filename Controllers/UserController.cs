using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;//TO USE SESSION
using time_tracker.Models;
using time_tracker.DataBase;

namespace time_tracker.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<TimeTrackerHomeController> _logger;
        private DataBaseContext _DataBaseContext;

        public UserController(DataBaseContext DataBaseContext,ILogger<TimeTrackerHomeController> logger)
        {
            _DataBaseContext = DataBaseContext;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(int userId)
        {        
            return View();
        }
    }
}