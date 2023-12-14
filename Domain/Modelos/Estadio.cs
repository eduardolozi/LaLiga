using Domain.Enums;
using LinqToDB.Mapping;

namespace Domain.Modelos
{
    [Table("Estadio")]
    public class Estadio
    {
        [PrimaryKey, Identity] public int Id { get; set; }

        [Column("TimeId"), Nullable] public int TimeId { get; set; }

        [Association(ThisKey = "TimeId", OtherKey = "Time.Id")] public Time Time { get; set; }

        [Column("Nome"), NotNull] public EstadioEnum Nome { get; set; }

        [Column("FotoEstadio"), Nullable] public string? FotoEstadio { get; set; }

        [Column("Capacidade"), NotNull] public int Capacidade { get; set; }
    }
}
