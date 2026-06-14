using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IAplicacaoRepository
    {
        List<Aplicacao> BuscarAplicacoesAnimal(int animalId);
        List<Aplicacao> BuscarAplicacoesInativasAnimal (int animalId);
        void Adicionar(Aplicacao aplicacao);
        public Aplicacao Encontrar(int id);
        public List<Vacina> EncontrarVacinas();
        public void Editar(Aplicacao aplicacao);
        public void Inativar(int id);
        public void Ativar(int id);
        Aplicacao BuscarPorId(int id);
    }
}
