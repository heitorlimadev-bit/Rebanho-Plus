using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IRacaRepository
    {
        List<Raca> BuscarTodos();
        List<Raca> BuscarInativos();
        void Adicionar(Raca raca);
        public Raca Encontrar(int id);
        public void Editar(Raca raca);
        public void Inativar(int id);
        public void Ativar(int id);
    }
}
