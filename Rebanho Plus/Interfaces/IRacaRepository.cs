using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IRacaRepository
    {
        List<Raca> BuscarTodos();
        List<Raca> BuscarInativos();
        void Adicionar(Raca raca);
        public void Editar(int id);
        public void Inativar(int id);
    }
}
