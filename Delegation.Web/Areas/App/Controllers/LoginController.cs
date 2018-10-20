using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Delegation.Web.Areas.App.Controllers
{
    [Area("App")]
    [Route("[area]/[controller]")]
    public class LoginController : Controller
    {
        public LoginController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}