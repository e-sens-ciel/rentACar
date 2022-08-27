using BL;
using Microsoft.AspNetCore.Mvc;
using MODELS.Client;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        //private readonly LoginCheckQuery _loginCheck;
        //public HomeController(LoginCheckQuery loginCheckQuery)
        //{
        //    _loginCheck = loginCheckQuery;
        //}


        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Client ad)
        {
            var _loginCheck = new LoginCheckQuery();
            int res = _loginCheck.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "You are welcome to Admin Section";
            }
            else
            {
                TempData["msg"] = "Admin id or Password is wrong.!";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}