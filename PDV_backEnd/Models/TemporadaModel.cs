namespace PDV_backEnd.Models
{
    public class TemporadaModel
    {
        public int TEM_ID { get; set; }
        public int TEM_NUMTEM { get; set; }
        public string? TEM_NOME { get; set; }
        public int TEM_ETAPAS { get; set; }
        public string? TEM_INICIO { get; set; }
        public string? TEM_FINAL { get; set; }
        public int TEM_ANO {  get; set; }
    }
}