using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CleverDogStudios.FormulaOnePickr.Data.DataContexts;

namespace CleverDogStudios.FormulaOnePickr.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "F1 Drivers - MVC";

            using (var db = new FormulaOnePickrContext())
            {
                
                var drivers = from p in db.Drivers.Include("Team")
                                  orderby p.FirstName
                                  select p;
//
//                ViewData.Model = drivers.ToList();

                db.Teams.Load();
                ViewData.Model = db.Drivers.ToList();
            }

//            var service = new FormulaOnePickrService.FormulaOnePickrServiceClient();
//            var retval = service.GetDrivers();
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
