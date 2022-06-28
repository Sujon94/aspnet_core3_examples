using Microsoft.AspNetCore.Mvc;

namespace IntroductoryProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
    }
}
