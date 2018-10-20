using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Delegation.Web.Models;
using Delegation.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Delegation.Core.Models;
using Delegation.Infrastructure.CQS.Bus;

namespace Delegation.Web.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IQueryBus _queryBus;
        public HomeController(IQueryBus queryBus)
        {
            _queryBus = queryBus;
            //_userManager = umanager;

            //_signInManager = smanager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
