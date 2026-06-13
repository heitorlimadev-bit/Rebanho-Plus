using Microsoft.AspNetCore.Mvc;
using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace Rebanho_Plus.Controllers
{
    public class GadoController : Controller
    {
        private GadoRepository repository;
        public GadoController(GadoRepository repository)
        { 
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var animais = repository.BuscarTodos();
            return View(animais);
        }
        public IActionResult Buscar(int id,int maeId,string raca, Status status)
        {
            var animais = repository.Buscar(id, maeId, raca, status);
            return View(animais);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Gado gado)
        {
            repository.Adicionar(gado);
            return RedirectToAction("Index");
        }
        public IActionResult Inativar(int id) 
        {
            repository.Inativar(id);
            return RedirectToAction("Index");
        }
    }
}
