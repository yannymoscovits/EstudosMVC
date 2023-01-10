using EstudosMVCsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosMVCsite.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Nome = "Yanny Moscovits";
            model.Email = "yannymoscovits@gmail.com";
            return View(model);

        }

        public IActionResult Privacy()
        {
            HomeModel model = new HomeModel();
            model.Nome = "Yanny Moscovits";
            model.Email = "yannymoscovits@gmail.com";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
