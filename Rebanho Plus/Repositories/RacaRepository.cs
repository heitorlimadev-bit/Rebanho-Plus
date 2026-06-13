using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;

namespace Rebanho_Plus.Repositories
{
    public class RacaRepository : IRacaRepository
    {
        private ConteudoBanco context;
        public RacaRepository(ConteudoBanco context)
        { 
            this.context = context;
        }
        public List<Raca> BuscarTodos()
        {
            return context.Racas.Where(r => r.Status == Status.ativo).ToList();
        }
        public List<Raca> BuscarInativos()
        {
            return context.Racas.Where(r => r.Status == Status.inativo).ToList();
        }
        public void Adicionar(Raca raca)
        {
            context.Racas.Add(raca);
            context.SaveChanges();
        }
        public void Editar(int id)
        {
            var raca = context.Racas.Find(id);
            context.Racas.Update(raca);
            context.SaveChanges();
        }
        public void Inativar(int id)
        {
            var raca = context.Racas.Find(id);
            raca.Status = Status.inativo;
            context.Update(raca);
        }
    }
}
