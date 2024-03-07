using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Persion ps)
        {
            string strOutput = "xin chao " + ps.PersionId + " - " + ps.FullName + " - " + ps.Address ;
            ViewBag.infoPersion = strOutput;
            return View();
        }
    }
}