using System;
using System.Web.Mvc;

namespace JustGivingAutomationRecruitment.Controllers
{
    public class Exercise3Controller : Controller
    {
        public ActionResult Index()
        {
            var random = new Random();
            Session["SpecialRow"] = random.Next(1, 10);

            return View();
        }

        
        public ActionResult Result(int id)
        {
            var specialRow = (int) Session["SpecialRow"];

            if (specialRow > 0)
            {
                @ViewBag.Exercise3Result = id == specialRow ? "Well done, you opened the right link!" : "Sorry, you opened the wrong link!";
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}