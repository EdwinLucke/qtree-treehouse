using System.Web.Mvc;

namespace qtree.Asp.Net.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = $"Home Page - {qtree.standard.lib.TechnologyTypes.Net}";
           
            return View();
        }
    }
}
