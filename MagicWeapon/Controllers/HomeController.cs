using System.Web.Mvc;
using MagicWeapon.Data.Services;

namespace MagicWeapon.Controllers
{
    public class HomeController : Controller
    {
        private IWeaponData db;

        public HomeController()
        {
            db = new InMemoryWeaponData();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

    }
}