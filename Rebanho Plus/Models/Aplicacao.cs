namespace Rebanho_Plus.Models
{
    public class Aplicacao
    {
        public int Id { get; set; }
        public int VacinaId { get; set; }
        public Vacina vacina { get; set; }
        public int GadoId { get; set; }
        public Gado Gado { get; set; }
        public DateTime DataAplicacao { get; set; }
    }
}
