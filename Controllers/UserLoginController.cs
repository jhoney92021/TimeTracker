using System;//SO YOU DONT HAVE TO SAY System.Console
using System.Linq;//GIVES ACCESS TO LANGUAGE INTEGRATED QUERY
using Microsoft.AspNetCore.Identity;//TO USE HASHER
using Microsoft.AspNetCore.Mvc;//TO USE MVC FRAMEWORK
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;//TO USE SESSION
using time_tracker.Models;
using time_tracker.ViewModels;
using time_tracker.DataBase;

namespace time_tracker.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly ILogger<UserLoginController> _logger;
        private DataBaseContext _DataBaseContext;
        public UserLoginController(DataBaseContext context, ILogger<UserLoginController> logger)
        {
            _DataBaseContext = context;
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel thisUser)
        {
            //return View("Index");
            if(ModelState.IsValid)
            {
                UserModel liveUser = _DataBaseContext.Users.FirstOrDefault(user => user.EmailAddress == thisUser.EmailAddress);
                if(liveUser == null){ModelState.AddModelError("EmailAddress", "Login Failed");return View("Index");}

                var hasher = new PasswordHasher<UserLoginViewModel>();
                var result = hasher.VerifyHashedPassword(thisUser, liveUser.Password, thisUser.Password);

                if(result == 0){ModelState.AddModelError("Password", "Login Failed");return View("Index");}                

                HttpContext.Session.SetInt32("liveUser", liveUser.UserId);                
                
                return RedirectToAction("Index", "User", liveUser);
            }
            else
            {
                UserModel liveUser = _DataBaseContext.Users.FirstOrDefault(user => user.EmailAddress == thisUser.EmailAddress); 
                                
                return View("Index");
            }
        }

        public IActionResult Create(UserModel NewUser)
        {
            if(ModelState.IsValid)
            {
                
                if(_DataBaseContext.Users.Any(user => user.EmailAddress == NewUser.EmailAddress))
                {
                    ModelState.AddModelError("EmailAddress", "EmailAddress already in use!");
                    return View("Index");
                }
                PasswordHasher<UserModel> Hasher = new PasswordHasher<UserModel>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                _DataBaseContext.Add(NewUser);
                _DataBaseContext.SaveChanges();

                HttpContext.Session.SetInt32("liveUser", NewUser.UserId);                
                
                return RedirectToAction("Index", "User", NewUser);
            }
            else
            {                
                return View("Index");
            }
        }
        
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Success()
        {
            UserModel user = _DataBaseContext.Users.FirstOrDefault(user => user.UserId == HttpContext.Session.GetInt32("liveUser"));
            if(user != null)
            {                
                return View(user);
            }else{
                ModelState.AddModelError("EmailAddress", "Must be logged in!");
                return View("Index");
            }
        }
    }
}
