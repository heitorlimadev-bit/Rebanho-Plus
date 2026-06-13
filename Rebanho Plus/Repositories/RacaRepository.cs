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
        public void Adicionar(Raca raca)
        {
            context.Racas.Add(raca);
        }
    }
}
