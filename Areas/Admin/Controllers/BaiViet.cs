using Microsoft.AspNetCore.Mvc;

namespace Bai_02.Areas.Admin.Controllers
{
    public class BaiViet : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
