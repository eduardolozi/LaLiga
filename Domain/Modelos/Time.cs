using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime AnoFundacao { get; set; }
        public string NomeEstadio { get; set; }
        public string? FotoEscudo { get; set; }
        public string? FotoEstadio { get; set; }
        public List<int> JogadoresId { get; set; }
        public List<Jogador> Jogadores { get; set; }
    }
}
