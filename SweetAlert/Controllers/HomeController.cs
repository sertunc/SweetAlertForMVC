using System.Web.Mvc;

namespace SweetAlert.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string mesaj)
        {
            ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Error", "Username or Password Wrong", SweetAlertMessageType.error);

            return View();
        }
    }
}