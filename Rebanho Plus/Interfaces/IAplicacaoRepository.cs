using Rebanho_Plus.Models;

namespace Rebanho_Plus.Interfaces
{
    public interface IAplicacaoRepository
    {
        List<Aplicacao> BuscarAplicacoesAnimal(int animalId);
        void Adicionar(Aplicacao aplicacao);
    }
}
