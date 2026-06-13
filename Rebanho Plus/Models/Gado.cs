namespace Rebanho_Plus.Models
{
    public class Gado
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Fornecedor { get; set; }
        public string? FornecedorCNPJ { get; set; }
        public double? ValorCompra { get; set; }
        public int NotaFiscalCompra { get; set; }
        public double? ValorVenda { get; set; }
        public int NotaFiscalVenda { get; set; }
        public Genero Genero { get; set; }
        public Raca Raca { get; set; }
        public Status Status { get; set; }
        public DateTime DataNascimento { get; set; }
        public int MaeId { get; set; }
        public Gado Mae { get; set; }
        public List<Gado> Filhos { get; set; } = new List<Gado>();
        public List<Vacina> Vacinas { get; set; } = new List<Vacina>();
    }
}
