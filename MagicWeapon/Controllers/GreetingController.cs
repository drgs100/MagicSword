using System.Configuration;
using System.Web.Mvc;
using MagicWeapon.Models;

namespace MagicWeapon.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["Message"];
            return View(model);
        }
    }
}