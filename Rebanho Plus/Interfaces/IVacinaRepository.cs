using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IVacinaRepository
    {
        List<Vacina> BuscarTodos();
        List<Vacina> BuscarInativos();
        void Adicionar(Vacina vacina);
        public Vacina Encontrar(int id);
        public void Editar(Vacina vacina);
        public void Inativar(int id);
        public void Ativar(int id);
    }
}
