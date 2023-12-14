using Domain.Enums;

namespace Domain.Modelos
{
    public class Estadio
    {
        public int EstadioId { get; set; }
        public EstadioEnum Nome { get; set; }
        public string? FotoEstadio { get; set; }
        public int Capacidade { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }
    }
}
