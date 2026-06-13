using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IGadoRepository
    {
        List<Gado> BuscarTodos();
        List<Gado> Buscar(int? id,int? maeId, string? raca, Status status);
        void Adicionar(Gado gado);
        public void Editar(Gado gado);
        public void Inativar(Gado gado);
        public void Vender(Gado gado);

    }
}
