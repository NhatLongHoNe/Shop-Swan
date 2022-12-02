using Microsoft.AspNetCore.Mvc;

namespace ShopSwan.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult ManageBillDetail()
        {
            return View();
        }
        public IActionResult Revenue()
        {
            return View();
        }

    }
}
