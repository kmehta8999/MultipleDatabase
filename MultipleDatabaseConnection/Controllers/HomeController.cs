using Microsoft.AspNetCore.Mvc;


namespace DatabaseConnectionAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
