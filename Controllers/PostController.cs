using Microsoft.AspNetCore.Mvc;

namespace Bai_02.Controllers
{
    public class PostController : Controller
    {
        public IActionResult List()
        {
            @ViewBag.PageCode = 2;
            @ViewBag.PageName = "Danh sách bài";
            return View();
        }
        public IActionResult Detail()
        {
            @ViewBag.PageName = "Trang chi tiết";
            return View();
        }
    }
}
