using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IRacaRepository
    {
        List<Raca> BuscarTodos();
        void Adicionar(Raca raca);
    }
}
