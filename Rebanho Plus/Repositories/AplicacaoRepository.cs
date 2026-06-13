using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;

namespace Rebanho_Plus.Repositories
{

    public class AplicacaoRepository : IAplicacaoRepository
    {
        private ConteudoBanco context;
        public AplicacaoRepository(ConteudoBanco context)
        {
            this.context = context;
        }
        public List<Aplicacao> BuscarAplicacoesAnimal(int gadoId)
        {
            return context.Aplicacoes.Where(g => g.GadoId == gadoId).ToList();
        }
        public void Adicionar(Aplicacao aplicacao)
        {
            context.Aplicacoes.Add(aplicacao);
        }
    }
}
