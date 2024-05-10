using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Business.Services.Abstract;
using System.Diagnostics;

namespace MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;
        public HomeController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IActionResult Index()
        {
            var features = _featureService.GetAllFeatureAsync();
            return View(features);
        }

        public IActionResult HomeTwo()
        {
            return View();
        }
    }
}
