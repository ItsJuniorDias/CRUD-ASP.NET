using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // padrão
        public ActionResult Index()
        {
            return View();
        }
    }
}