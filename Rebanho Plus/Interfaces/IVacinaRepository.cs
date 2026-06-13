using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IVacinaRepository
    {
        List<Vacina> BuscarTodos();
        List<Vacina> BuscarInativos();
        void Adicionar(Vacina vacina);
        public void Editar(Vacina vacina);
        public void Inativar(Vacina vacina);
    }
}
