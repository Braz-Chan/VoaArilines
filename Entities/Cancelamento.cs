namespace VoaAirlines.Entities{
    public class Cancelamento{
        public Cancelamento(string? motivo, DateTime dataHoraNotificacao)
        {
            Motivo = motivo;
            DataHoraNotificacao = dataHoraNotificacao;
        }

        public int Id { get; set; }
        public string? Motivo { get; set; }
        public DateTime DataHoraNotificacao { get; set; }
        public int Vooid { get; set; }
        public Voo Voo { get; set; }=null!;
    }
}