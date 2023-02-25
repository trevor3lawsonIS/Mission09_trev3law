using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission09_trev3law.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_trev3law.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
