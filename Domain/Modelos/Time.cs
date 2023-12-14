using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public DateTime AnoFundacao { get; set; }
        public string? FotoEscudo { get; set; }
        public List<Jogador> Jogadores { get; set; }
        public Estadio Estadio { get; set; }
    }
}
