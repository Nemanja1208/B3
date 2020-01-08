using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace B3.Controllers
{
    public class KontaktController : Controller
    {
        //Returns a view Kontakt Page
        public IActionResult Kontakt()
        {
            return View();
        }
    }
}
