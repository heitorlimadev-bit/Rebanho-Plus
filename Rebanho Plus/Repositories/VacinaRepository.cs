using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;

namespace Rebanho_Plus.Repositories
{
    public class VacinaRepository : IVacinaRepository
    {
        private ConteudoBanco context;
        public VacinaRepository(ConteudoBanco context)
        {
            this.context = context;
        }
        public List<Vacina> BuscarTodos() 
        {
            return context.Vacinas.ToList();
        }
        public void Adicionar(Vacina vacina) 
        {
            context.Vacinas.Add(vacina);
        }
    }
}
