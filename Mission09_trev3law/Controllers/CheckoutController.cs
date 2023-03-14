using Microsoft.AspNetCore.Mvc;
using Mission09_trev3law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_trev3law.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }
    }
}
