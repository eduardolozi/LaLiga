using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    [Table("Time")]
    public class Time
    {
        [PrimaryKey, Identity] public int Id { get; set; }

        [Column("Nome"), NotNull] public string Nome { get; set; }

        [Column("AnoFundacao"), NotNull] public DateTime AnoFundacao { get; set; }

        [Column("FotoEscudo"), Nullable] public string? FotoEscudo { get; set; }

    }
}
