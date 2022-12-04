using Microsoft.AspNetCore.Mvc;

namespace CadastroProdutosWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}