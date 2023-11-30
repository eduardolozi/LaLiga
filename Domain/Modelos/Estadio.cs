using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Estadio
    {
        public int EstadioId { get; set; }
        public EstadioEnum Nome { get; set; }
        public string? FotoEstadio { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }
    }
}
