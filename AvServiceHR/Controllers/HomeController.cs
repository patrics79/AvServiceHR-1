using AvServiceHR.Contexts;
using AvServiceHR.Models;
using AvServiceHR.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AvServiceHR.Controllers
{
    public class HomeController : Controller
    {
        


        private readonly AdventureWorksServices _advServices;


        public HomeController( AdventureWorks2017Context context)
        {
            _advServices =  new AdventureWorksServices(context);
        }


        public async Task<IActionResult> Index()
        {

            var model = await _advServices.GetPersonTypeSc();
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
