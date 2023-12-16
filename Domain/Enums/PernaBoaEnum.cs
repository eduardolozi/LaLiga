using LinqToDB.Mapping;

namespace Domain.Enums
{
    public enum PernaBoaEnum
    {
        [MapValue("Direita")]
        Direita,
        [MapValue("Esquerda")]
        Esquerda
    }
}
