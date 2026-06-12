using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IRacaRepository
    {
        List<Raca> BuscarTodos();
        List<Raca> Buscar(int id);
        void Adicionar(Raca raca);
    }
}
