namespace PDV_backEnd.Models
{
    public class TracadoModel
    {
        public int TRA_ID { get; set; }
        public string? TRA_NOME { get; set; }
        public DateOnly TRA_DATA_ESTREIA { get; set; }
        public int? PIL_VENCEDOR { get; set; }
        public int? EQI_VENCEDORA { get; set; }
        public int? CLI_CLIMA { get; set; }
        public int? SEN_SENTIDO { get; set; }
        public int? KAR_KARTODROMO { get; set; }
        public int? CAL_NUMERO_ETAPA { get; set; }
        public int? MV_ESTREIA { get; set; }
        public int? MV_RECORD { get; set; }
    }
}
