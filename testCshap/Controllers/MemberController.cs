using Microsoft.AspNetCore.Mvc;

namespace testCshap.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult HelloAnnZi()
        {
            return View();
        }
    }
}
