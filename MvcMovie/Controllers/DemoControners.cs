using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {

            
                //gui du lieu tu controller ve view
                string result = "Tin hoc kinh te";
                ViewBag.thongbao = result;
                return View();
            
        }
        public IActionResult HelloWord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HelloWord(Person ps)
        {
            ps.Namsinh = DateTime.Now;
            ViewBag.thongbao = "Xin chao " + ps.MSV + "-" + ps.FullName + "-" + ps.Namsinh;
            return View();
        }
    }
}
        
