using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;

namespace Rebanho_Plus.Repositories
{
    public class GadoRepository : IGadoRepository
    {
        private ConteudoBanco context;
        public GadoRepository(ConteudoBanco context)
        {
            this.context = context;
        }
        public List<Gado> BuscarTodos() 
        {
            return context.Animais.ToList();
        }
        public List<Gado> Buscar(int? id, int? maeId, string? raca)
        {
            var query = context.Animais.AsQueryable();

            if (id.HasValue)
            {
                query = query.Where(g => g.Id == id);
            }
            if (maeId.HasValue)
            {
                query = query.Where(g => g.MaeId == maeId);
            }
            if (!string.IsNullOrEmpty(raca))
            {
                query = query.Where(g => g.Raca.Nome == raca);
            }

            return query.ToList();
        }
        public void Adicionar(Gado gado)
        {
            context.Animais.Add(gado);
        }
    }
}
