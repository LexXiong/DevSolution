using System.Web.Mvc;
using Boying;
using Boying.Localization;
using Boying.Themes;

namespace Boying.MainPage.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        public IBoyingServices Services { get; set; }

        public HomeController(IBoyingServices services)
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