using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Temp_Data.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            base.TempData["Name"] = "Vinit Suryarao";
            base.TempData["Age"] = 25;

            return View();
        }

        public IActionResult FirstRequest()
        {
            // Only Save Data
            TempData.Keep();

            // Save + Carry Data
            var Name1 = TempData.Peek("Name");

            return View();
        }


        public IActionResult SecondRequest()
        {
            // Only Save Data
            TempData.Keep();

            // Save + Carry Data
            var Name2 = TempData.Peek("Name");

            return View();
        }
    }
}