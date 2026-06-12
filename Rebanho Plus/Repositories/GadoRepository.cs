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
        public List<Gado> Buscar(int id)
        {
            return context.Animais.Where(g => g.Id == id).ToList();
            // adicionar query
        }
        public void Adicionar(Gado gado)
        {
            context.Animais.Add(gado);
        }
    }
}
