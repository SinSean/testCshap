using Microsoft.AspNetCore.Mvc;

namespace testCshap.Controllers
{
    public class shan : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HelloShan()
        {
            return View();
        }
    }
}
