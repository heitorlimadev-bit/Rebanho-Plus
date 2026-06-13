using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IAplicacaoRepository
    {
        List<Aplicacao> BuscarAplicacoesAnimal(int animalId);
        List<Aplicacao> BuscarAplicacoesInativasAnimal (int animalId);
        void Adicionar(Aplicacao aplicacao);
        public void Editar(Aplicacao aplicacao);
        public void Inativar(Aplicacao aplicacao);
    }
}
