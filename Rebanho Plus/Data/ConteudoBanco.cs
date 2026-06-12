using Microsoft.EntityFrameworkCore;
using Rebanho_Plus.Models;

namespace Rebanho_Plus.Data
{
    public class ConteudoBanco: DbContext
    {
        public ConteudoBanco(DbContextOptions <ConteudoBanco> options) : base(options) { }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Gado> Animais { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Aplicacao> Aplicacoes { get; set; }

    }
}
