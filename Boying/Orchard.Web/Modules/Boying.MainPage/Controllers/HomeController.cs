using System.Web.Mvc;
using Orchard;
using Orchard.Localization;

namespace Boying.MainPage.Controllers
{
    public class HomeController : Controller
    {
        public IOrchardServices Services { get; set; }

        public HomeController(IOrchardServices services)
        {
            Services = services;
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public ActionResult Index()
        {
            return View();
        }
    }
}