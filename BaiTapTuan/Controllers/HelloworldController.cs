using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BaiTapTuan.Controllers
{
    public class HelloworldController : Controller
    {
        public IActionResult Index(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
