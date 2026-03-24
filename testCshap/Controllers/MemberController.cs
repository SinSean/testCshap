using Microsoft.AspNetCore.Mvc;
using testCshap.Models;
using testCshap.ViewModels;

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
        public IActionResult List(CKeywordViewModel vm)
        {

            DbShizukuDemoContext db = new DbShizukuDemoContext();
            IEnumerable<TMember> datas = null;
            datas = from p in db.TMembers
                    select p;
            //if (string.IsNullOrEmpty(vm.txtKeyword))
            //    datas = from p in db.TMembers
            //            select p;
            //else
            //    datas = db.TMembers.Where(p => p.FName.Contains(vm.txtKeyword)
            //    || p.FPhone.Contains(vm.txtKeyword)
            //    || p.FAddress.Contains(vm.txtKeyword)
            //    || p.FEmail.Contains(vm.txtKeyword));

            return View(datas);
        }
        public IActionResult Block_List(CKeywordViewModel vm)
        {

            DbShizukuDemoContext db = new DbShizukuDemoContext();
            IEnumerable<TMember> datas = null;
            datas = from p in db.TMembers
                    select p;
            //if (string.IsNullOrEmpty(vm.txtKeyword))
            //    datas = from p in db.TMembers
            //            select p;
            //else
            //    datas = db.TMembers.Where(p => p.FName.Contains(vm.txtKeyword)
            //    || p.FPhone.Contains(vm.txtKeyword)
            //    || p.FAddress.Contains(vm.txtKeyword)
            //    || p.FEmail.Contains(vm.txtKeyword));

            return View(datas);
        }
    }
}
