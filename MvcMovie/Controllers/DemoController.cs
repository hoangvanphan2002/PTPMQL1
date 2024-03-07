using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fullName, string CCCD)
        {
            string strResult = "Xin chao " + fullName + "-" + CCCD;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}