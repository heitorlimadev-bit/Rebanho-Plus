using Microsoft.AspNetCore.Mvc;
using Rebanho_Plus.Models;
using Rebanho_Plus.Repositories;

namespace Rebanho_Plus.Controllers
{
    public class AplicacaoController : Controller
    {
        private AplicacaoRepository repository;
        public AplicacaoController(AplicacaoRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index(int id)
        {
            ViewBag.GadoId = id;
            var AplicacoesAtivas = repository.BuscarAplicacoesAnimal(id);
            var AplicacoesInativas = repository.BuscarAplicacoesInativasAnimal(id);
            Dictionary<string, List<Aplicacao>> todasAplicacoes = new()
            {
                { "Ativo", AplicacoesAtivas },
                { "Inativo", AplicacoesInativas }
            };
            return View(todasAplicacoes);
        }
        public IActionResult Adicionar(int gadoId)
        {
            ViewBag.Gadoid = gadoId;
            ViewBag.Vacinas = repository.EncontrarVacinas();
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Aplicacao Aplicacao)
        {

            repository.Adicionar(Aplicacao);
            return RedirectToAction("Index", new { id = Aplicacao.GadoId });
        }
        public IActionResult Editar(int id)
        {
            var aplicacao = repository.Encontrar(id);
            if (aplicacao != null)
            {
                ViewBag.GadoId = aplicacao.GadoId;
            }
            ViewBag.Vacinas = repository.EncontrarVacinas();
            return View(aplicacao);
        }
        [HttpPost]
        public IActionResult Editar(Aplicacao Aplicacao)
        {
            repository.Editar(Aplicacao);
            return RedirectToAction("Index", new { id = Aplicacao.GadoId });
        }
        public IActionResult Inativar(int id)
        {
            var aplicacao = repository.BuscarPorId(id);
            int gadoId = aplicacao?.GadoId ?? 0;
            repository.Inativar(id);
            return RedirectToAction("Index", new { id = gadoId });
        }
        public IActionResult Ativar(int id)
        {
            var aplicacao = repository.BuscarPorId(id);
            int gadoId = aplicacao?.GadoId ?? 0;
            repository.Ativar(id);
            return RedirectToAction("Index", new { id = gadoId });
        }
    }
}