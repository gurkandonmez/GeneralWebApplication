using Microsoft.AspNetCore.Mvc;

namespace GeneralWebApplication.Controllers
{
    public class ArticleCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
