using Microsoft.AspNet.Mvc;


namespace Angular2ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}