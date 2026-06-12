using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IGadoRepository
    {
        List<Gado> BuscarTodos();
        List<Gado> Buscar(int id);
        void Adicionar(Gado gado);
    }
}
