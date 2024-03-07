using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SinhvienControler : Controller
    {
        public IActionResult dulieu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dulieu(Sinhvien sv)
        {
            string strOutput  = "xin chao" + sv.FullName + "-" + sv.Age ;
            ViewBag.dulieu = strOutput ;
            return View();
        }

    }
}