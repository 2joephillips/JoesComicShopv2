using System.Web.Mvc;

namespace JoesComicShopv2.Web.Controllers
{
    public class HomeController : JoesComicShopv2ControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}