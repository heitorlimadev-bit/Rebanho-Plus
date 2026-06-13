using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IVacinaRepository
    {
        List<Vacina> BuscarTodos();
        void Adicionar(Vacina vacina);
    }
}
