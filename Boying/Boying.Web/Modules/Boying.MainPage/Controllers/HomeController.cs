using System.Web.Mvc;
using Boying;
using Boying.Localization;

namespace Boying.MainPage.Controllers
{
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