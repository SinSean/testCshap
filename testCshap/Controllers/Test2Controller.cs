using Microsoft.AspNetCore.Mvc;

namespace testCshap.Controllers
{
    public class Test2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Hello()
        {
            return "Hello";
        }

        public string Hello2()
        {
            return "Hello2";
        }
    }
}
