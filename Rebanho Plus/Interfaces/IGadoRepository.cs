using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IGadoRepository
    {
        List<Gado> BuscarTodos();
        List<Gado> Buscar(int? id,int? maeId, string? raca, Status status);
        void Adicionar(Gado gado);
        public Gado Encontrar(int id);
        public void Editar(Gado gado);
        public void Inativar(int id);
        public void Vender(int id,double valorVenda);
        public void Ativar(int id);


    }
}
