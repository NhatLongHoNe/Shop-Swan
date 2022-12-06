using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ShopSwan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSwan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult Introduce()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
       
        public IActionResult ManageBillDetail()
        {
            return View();
        }
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult PersionalBillDetail()
        {
            return View();
        }
        public IActionResult PersionalBill()
        {
            return View();
        }
        public IActionResult Persional()
        {
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Revenue()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            if (user != null)
            {
                var Users = new List<UserModel>();
                // lưu session
                var json = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("User", json);

                //lst danh sách
                var jsons = HttpContext.Session.GetString("Users");
                if (jsons !=null)
                {
                    Users = JsonConvert.DeserializeObject<List<UserModel>>(jsons);
                    Users.Add(user);
                }
                else
                {
                    Users.Add(user);
                }
                var jsonUsers = JsonConvert.SerializeObject(Users);
                HttpContext.Session.SetString("Users", jsonUsers);
            }

            return Json(true);
        }
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            var jsons = HttpContext.Session.GetString("Users");
            if (jsons !=null)
            {
                var Users = JsonConvert.DeserializeObject<List<UserModel>>(jsons);

                var data = Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);


                    //Users.Where(x => x.Email.ToLower()==(user.Email.ToLower()) && x.Password.ToLower()==(user.Password.ToLower())).FirstOrDefault();
                if (data != null)
                {
                    var json = JsonConvert.SerializeObject(data);
                    HttpContext.Session.SetString("User", json);
                    return Json(true);
                }
            }
            
            return Json(false);

        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("User");
            return Json(true);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
