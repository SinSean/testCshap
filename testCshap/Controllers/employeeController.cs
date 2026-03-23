using Microsoft.AspNetCore.Mvc;

namespace testCshap.Controllers
{
    public class employeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
