using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomeTwo()
        {
            return View();
        }
    }
}
