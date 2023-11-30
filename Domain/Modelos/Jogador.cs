using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Jogador
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public PernaBoa PernaBoa { get; set; }
        public Posicao Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public string? Foto { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }
    }
}
