using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;
using Microsoft.EntityFrameworkCore;

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
            return context.Aplicacoes.Include(g => g.Vacina).Where(g => g.GadoId == gadoId && g.Status == Status.ativo).ToList();
        }
        public List<Aplicacao> BuscarAplicacoesInativasAnimal(int gadoId)
        {
            return context.Aplicacoes.Include(g => g.Vacina).Where(g => g.GadoId == gadoId && g.Status == Status.inativo).ToList();
        }
        public void Adicionar(Aplicacao aplicacao)
        {
            if (aplicacao.VacinaId > 0)
            {
                var existingVacina = context.Vacinas.Find(aplicacao.VacinaId);
                if (existingVacina != null)
                {
                    aplicacao.Vacina = existingVacina;
                }
            }
            if (aplicacao.GadoId > 0)
            {
                var existingGado = context.Animais.Find(aplicacao.GadoId);
                if (existingGado != null)
                {
                    aplicacao.Gado = existingGado;
                }
            }
            context.Aplicacoes.Add(aplicacao);
            context.SaveChanges();
        }
        public Aplicacao Encontrar(int id)
        {
            var aplicacao = context.Aplicacoes.Find(id);
            return aplicacao;
        }
        public List<Vacina> EncontrarVacinas()
        {
            var vacinas = context.Vacinas.ToList();
            return vacinas;
        }
        public void Editar(Aplicacao aplicacao)
        {
            context.Aplicacoes.Update(aplicacao);
            context.SaveChanges();
        }
        public void Inativar(int id)
        {
            var aplicacao = context.Aplicacoes.Find(id);
            if (aplicacao != null)
            {
                aplicacao.Status = Status.inativo;
                context.Update(aplicacao);
                context.SaveChanges();
            }
        }
        public void Ativar(int id)
        {
            var aplicacao = context.Aplicacoes.Find(id);
            if (aplicacao != null)
            {
                aplicacao.Status = Status.ativo;
                context.Update(aplicacao);
                context.SaveChanges();
            }
        }
        public Aplicacao BuscarPorId(int id)
        {
            return context.Aplicacoes.Find(id);
        }
    }
}
