using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MillerSoftwareSolutions.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MillerSoftwareSolutions.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome"
            };

            return View(homeViewModel);
        }
    }
}
