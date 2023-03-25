using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuan.Controllers
{
    public class HelloworldController1 : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
