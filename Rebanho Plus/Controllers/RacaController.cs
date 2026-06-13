using Microsoft.AspNetCore.Mvc;
using Rebanho_Plus.Models;
using Rebanho_Plus.Repositories;

namespace Rebanho_Plus.Controllers
{
    public class RacaController : Controller
    {
        private RacaRepository repository;
        public RacaController(RacaRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var racasAtivas = repository.BuscarTodos();
            var racasInativas = repository.BuscarInativos();
            Dictionary<string, List<Raca>> todasRacas = new();
            return View(todasRacas);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Adicionar(Raca raca)
        {
            repository.Adicionar(raca);
            return RedirectToAction("Index");
        }
        public IActionResult Inativar(int id)
        {
            repository.Inativar(id);
            return RedirectToAction("Index");
        }
    }
}
