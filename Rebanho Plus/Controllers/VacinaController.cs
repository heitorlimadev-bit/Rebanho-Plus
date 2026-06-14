using Microsoft.AspNetCore.Mvc;
using Rebanho_Plus.Models;
using Rebanho_Plus.Repositories;

namespace Rebanho_Plus.Controllers
{
    public class VacinaController : Controller
    {
        private VacinaRepository repository;
        public VacinaController(VacinaRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var vacinasAtivas = repository.BuscarTodos();
            var vacinasInativas = repository.BuscarInativos();
            Dictionary<string, List<Vacina>> todasVacinas = new()
            {
                { "Ativo", vacinasAtivas },
                { "Inativo", vacinasInativas }
            };
            return View(todasVacinas);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Vacina vacina)
        {
            repository.Adicionar(vacina);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            repository.Encontrar(id);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(Vacina vacina)
        {
            repository.Editar(vacina);
            return RedirectToAction("Index");
        }
        public IActionResult Inativar(int id)
        {
            repository.Inativar(id);
            return RedirectToAction("Index");
        }
        public IActionResult Ativar(int id)
        {
            repository.Ativar(id);
            return RedirectToAction("Index");
        }
    }
}