using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class OverViewController : Controller
    {
        [Route("admin/overview")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
