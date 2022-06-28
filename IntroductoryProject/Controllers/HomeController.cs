using Microsoft.AspNetCore.Mvc;
using System;

namespace IntroductoryProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string ViewModel = hour < 12 ? "Good morning" : "Good aternoon";
            return View("MyView",ViewModel);
        }
    }
}
