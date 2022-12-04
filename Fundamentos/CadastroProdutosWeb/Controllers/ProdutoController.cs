using CadastroProdutosWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroProdutosWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produto> ListaProdutos { get; set; } = new List<Produto>();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto model)
        {
            ListaProdutos.Add(model);
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(ListaProdutos);
        }
    }
}
