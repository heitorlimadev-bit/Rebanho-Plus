using Rebanho_Plus.Interfaces;
using Rebanho_Plus.Models;
using Rebanho_Plus.Data;
using Microsoft.EntityFrameworkCore;

namespace Rebanho_Plus.Repositories
{
    public class GadoRepository : IGadoRepository
    {
        private ConteudoBanco context;
        public GadoRepository(ConteudoBanco context)
        {
            this.context = context;
        }
        public List<Gado> BuscarTodos()
        {
            return context.Animais.Include(g => g.Raca).ToList();
        }
        public List<Gado> Buscar(int? id, int? maeId, string? raca, Status status)
        {
            var query = context.Animais.Include(g => g.Raca).AsQueryable();

            if (id.HasValue)
            {
                query = query.Where(g => g.Id == id);
            }
            if (maeId.HasValue)
            {
                query = query.Where(g => g.MaeId == maeId);
            }
            if (!string.IsNullOrEmpty(raca))
            {
                query = query.Where(g => g.Raca.Nome == raca);
            }
            query = query.Where(g => g.Status == status);

            return query.ToList();
        }
        public void Adicionar(Gado gado)
        {
            if (gado.Raca != null)
            {
                var existingRaca = context.Racas.Find(gado.Raca.Id);
                if (existingRaca != null)
                {
                    gado.Raca = existingRaca;
                }
            }
            context.Animais.Add(gado);
            context.SaveChanges();
        }
        public Gado Encontrar(int id)
        {
            var gado = context.Animais.Find(id);
            return gado;
        }
        public void Editar(Gado gado)
        {
            if (gado.Raca != null)
            {
                var existingRaca = context.Racas.Find(gado.Raca.Id);
                if (existingRaca != null)
                {
                    gado.Raca = existingRaca;
                }
            }
            context.Animais.Update(gado);
            context.SaveChanges();
        }
        public void Inativar(int id)
        {
            var gado = context.Animais.Find(id);
            if (gado != null)
            {
                gado.Status = Status.inativo;
                context.Update(gado);
                context.SaveChanges();
            }
        }
        public void Vender(int id,double valorVenda)
        {
            var gado = context.Animais.Find(id);
            if (gado != null)
            {
                gado.Status = Status.vendido;
                gado.ValorVenda = valorVenda;
                context.Update(gado);
                context.SaveChanges();
            }
        }
        public void Ativar(int id)
        {
            var gado = context.Animais.Find(id);
            if (gado != null)
            {
                gado.Status = Status.ativo;
                context.Update(gado);
                context.SaveChanges();
            }
        }
    }
}