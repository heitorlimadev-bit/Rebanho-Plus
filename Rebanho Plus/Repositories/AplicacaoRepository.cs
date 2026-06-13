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
            return context.Aplicacoes.Where(g => g.GadoId == gadoId && g.Status == Status.ativo).ToList();
        }
        public List<Aplicacao> BuscarAplicacoesInativasAnimal(int gadoId)
        {
            return context.Aplicacoes.Where(g => g.GadoId == gadoId && g.Status == Status.inativo).ToList();
        }
        public void Adicionar(Aplicacao aplicacao)
        {
            context.Aplicacoes.Add(aplicacao);
            context.SaveChanges();
        }
        public void Editar(int id)
        {
            var aplicacao = context.Aplicacoes.Find(id);
            context.Aplicacoes.Update(aplicacao);
            context.SaveChanges();
        }
        public void Inativar(int id)
        {
            var aplicacao = context.Aplicacoes.Find(id);
            aplicacao.Status = Status.inativo;
            context.Update(aplicacao);
        }
    }
}
