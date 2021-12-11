using Microsoft.AspNetCore.Mvc;

namespace Bai_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.PageCode = 1;
            @ViewBag.PageName = "Trang danh mục";
            return View();
        }
        public IActionResult Contact()
        {
            @ViewBag.PageCode = 3;
            @ViewBag.PageName = "Liên hệ";
            return View();
        }
    }
}
