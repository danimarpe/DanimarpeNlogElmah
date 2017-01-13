
using System.Web.Mvc;

namespace DanimarpeNlogElmah.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Logger.LoggerManager.Instance.Elmah.Error("Oh no, an error ocurred!");

            return View();
        }
    }
}