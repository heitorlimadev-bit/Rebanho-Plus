using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IVacinaRepository
    {
        List<Vacina> BuscarTodos();
        List<Vacina> BuscarInativos();
        void Adicionar(Vacina vacina);
        public void Editar(int id);
        public void Inativar(int id);
    }
}
