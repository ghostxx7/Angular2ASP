using Microsoft.AspNet.Mvc;


namespace Angular2ASP.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Message() => PartialView();
        
        public IActionResult Numbers() => PartialView();
    }
}