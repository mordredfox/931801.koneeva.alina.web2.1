using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class CalcServiceController : Controller
    {
        Random rand = new Random();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        {
            int a = rand.Next(0, 10);
            int b = rand.Next(0, 10);
            if (b == 0) { return Redirect("~/CalcService/Error"); }
            var viewModel = new Numbers()
            {
                ValueFirst = a,
                ValueSecond = b
            };
            return View(viewModel);
        }
        public IActionResult PassUsingViewData()
        {
            ViewData["ValueFirst"] = rand.Next(0, 10);
            ViewData["ValueSecond"] = rand.Next(0, 10);
            if ((int)ViewData["ValueSecond"] == 0) { return Redirect("~/CalcService/Error"); }
            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            ViewBag.ValueFirst = rand.Next(0, 10);
            ViewBag.ValueSecond = rand.Next(0, 10);
            if (ViewBag.ValueSecond == 0) { return Redirect("~/CalcService/Error"); }
            return View();
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
