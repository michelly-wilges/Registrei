namespace Registrei.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
