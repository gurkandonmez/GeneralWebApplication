using Microsoft.AspNetCore.Mvc;

namespace GeneralWebApplication.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
