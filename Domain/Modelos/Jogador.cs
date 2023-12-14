using Domain.Enums;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    [Table("Jogador")]
    public class Jogador
    {
        [PrimaryKey, Identity] public int Id {  get; set; }

        [Column("TimeId"), Nullable] public int TimeId { get; set; }

        [Association(ThisKey = "TimeId", OtherKey = "Time.Id")] public Time Time { get; set; }

        [Column("Nome"), NotNull] public string Nome { get; set; }

        [Column("Idade"), NotNull] public int Idade { get; set; }

        [Column("PernaBoa"), NotNull] public PernaBoaEnum PernaBoa { get; set; }

        [Column("Posicao"), NotNull] public PosicaoEnum Posicao { get; set; }

        [Column("Nacionalidade"), NotNull] public string Nacionalidade { get; set; }

        [Column("NumeroCamisa"), NotNull] public int NumeroCamisa { get; set; }

        [Column("Foto"), Nullable] public string? Foto { get; set; }

    }
}
