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
            return context.Racas.ToList();
        }
        public List<Raca> Buscar(int id)
        {
            return context.Racas.Where(g => g.Id == id).ToList();
            // adicionar query
        }
        public void Adicionar(Raca raca)
        {
            context.Racas.Add(raca);
        }
    }
}
