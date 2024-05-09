using Microsoft.AspNetCore.Mvc;

namespace MVC_CRUD.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleProductVariable()
        {
            return View();
        }
    }
}
