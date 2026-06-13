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
            return context.Vacinas.Where(v => v.Status == Status.ativo).ToList();
        }
        public List<Vacina> BuscarInativos()
        {
            return context.Vacinas.Where(v => v.Status == Status.inativo).ToList();
        }
        public void Adicionar(Vacina vacina) 
        {
            context.Vacinas.Add(vacina);
            context.SaveChanges();
        }
        public void Editar(int id)
        {
            var vacina = context.Vacinas.Find(id);
            context.Vacinas.Update(vacina);
            context.SaveChanges();
        }
        public void Inativar (int id)
        {
            var vacina = context.Vacinas.Find(id);
            vacina.Status = Status.inativo;
            context.Update(vacina);
        }
    }
}
