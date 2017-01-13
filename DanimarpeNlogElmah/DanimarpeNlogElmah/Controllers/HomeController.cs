
using System.Web.Mvc;

namespace DanimarpeNlogElmah.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Logger.LoggerManager.Instance.Elmah.Debug("Hello");
            Logger.LoggerManager.Instance.Elmah.Error("Oh no, an error ocurred!");
            Logger.LoggerManager.Instance.Elmah.Fatal("Oh no, a REAL error ocurred!");
            Logger.LoggerManager.Instance.Elmah.Warn("Meh, shit happens");
            Logger.LoggerManager.Instance.Elmah.Trace("You are here");
            Logger.LoggerManager.Instance.Elmah.Info("And this program is ending");

            return View();
        }
    }
}