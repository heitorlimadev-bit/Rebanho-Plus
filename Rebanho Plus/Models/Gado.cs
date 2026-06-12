namespace Rebanho_Plus.Models
{
    public class Gado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public int NotaFiscal { get; set; }
        public Genero Genero { get; set; }
        public Raca Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int MaeId { get; set; }
        public Gado mae { get; set; }
        public List<Gado> Filhos { get; set; } = new List<Gado>();
        public List<Vacina> Vacinas { get; set; } = new List<Vacina>();
    }
}
