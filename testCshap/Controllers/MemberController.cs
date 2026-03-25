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

        public IActionResult Delete(int? id)
        {
            DbShizukuDemoContext db = new DbShizukuDemoContext();
            TMember x = db.TMembers.FirstOrDefault(p => p.FId == id);
            if (x != null)
            {
                x.FIsActive = false;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public IActionResult Restore(int? id)
        {
            DbShizukuDemoContext db = new DbShizukuDemoContext();
            TMember x = db.TMembers.FirstOrDefault(p => p.FId == id);
            if (x != null)
            {
                x.FIsActive = true;
                db.SaveChanges();
            }
            return RedirectToAction("Block_List");
        }

        //public IActionResult Edit(int? id)
        //{
        //    DbDemoContext db = new DbDemoContext();
        //    TCustomer x = db.TCustomers.FirstOrDefault(p => p.FId == id);
        //    if (x == null)
        //        return RedirectToAction("List");
        //    return View(x);
        //}
        //[HttpPost]
        //public IActionResult Edit(TCustomer uiCustomer)
        //{
        //    DbDemoContext db = new DbDemoContext();
        //    TCustomer dbCustomer = db.TCustomers.FirstOrDefault(p => p.FId == uiCustomer.FId);
        //    if (dbCustomer != null)
        //    {
        //        dbCustomer.FName = uiCustomer.FName;
        //        dbCustomer.FPassword = uiCustomer.FPassword;
        //        dbCustomer.FPhone = uiCustomer.FPhone;
        //        dbCustomer.FEmail = uiCustomer.FEmail;
        //        dbCustomer.FAddress = uiCustomer.FAddress;
        //        db.SaveChanges();
        //    }
        //    return RedirectToAction("List");
        //}
    }
}
