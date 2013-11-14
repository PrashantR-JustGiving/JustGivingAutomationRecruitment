using System;
using System.Web.Mvc;

namespace JustGivingAutomationRecruitment.Controllers
{
    public class Exercise3Controller : Controller
    {
        public ActionResult Index()
        {
            var random = new Random();
            MvcApplication.Exercise3SpecialRow = random.Next(1, 10);

            TempData["SpecialRow"] = MvcApplication.Exercise3SpecialRow;

            return View();
        }

        
        public ActionResult Result(int id)
        {
            if (MvcApplication.Exercise3SpecialRow > 0)
            {
                @ViewBag.Exercise3Result = id == MvcApplication.Exercise3SpecialRow ? "Well done, you opened the right link!" : "Sorry, you opened the wrong link!";
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}