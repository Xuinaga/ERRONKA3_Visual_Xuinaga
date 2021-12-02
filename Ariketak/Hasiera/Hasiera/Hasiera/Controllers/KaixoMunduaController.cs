using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Hasiera.Controllers
{
    public class KaixoMunduaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OngiEtorri(string izena, int zenbat = 7)
        {
            ViewBag.Mezua = "Hello " + izena;
            ViewBag.Zenbat = zenbat;
            return View();
        }


    }
}
