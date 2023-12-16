using LinqToDB.Mapping;

namespace Domain.Enums
{
    public enum EstadioEnum
    {

        [MapValue("Santiago Bernabeu")]
        SantiagoBernabeu,
        [MapValue("Civitas Metropolitano")]
        CivitasMetropolitano,
        [MapValue("Benito Villamarin")]
        BenitoVillamarin,
        [MapValue("San Mames")]
        SanMames,
        [MapValue("Camp Nou")]
        CampNou,
        [MapValue("Mestalla")]
        Mestalla,
        [MapValue("Ramon Sanchez Pizjuan")]
        RamonSanchezPizjuan,
        [MapValue("Reale Arena")]
        RealeArena,
        [MapValue("Estadio De Gran Canaria")]
        EstadioDeGranCanaria,
        [MapValue("Abanca Balaidos")]
        AbancaBalaidos,
        [MapValue("El Sadar")]
        ElSadar,
        [MapValue("La Ceramica")]
        LaCeramica,
        [MapValue("Nuevo Mirandilla")]
        NuevoMirandilla,
        [MapValue("Mallorca Son Moix")]
        MallorcaSonMoix,
        [MapValue("Mendizorroza")]
        Mendizorroza,
        [MapValue("Nuevo Los Carmenes")]
        NuevoLosCarmenes,
        [MapValue("Powe Horse Stadium")]
        PoweHorseStadium,
        [MapValue("Coliseum")]
        Coliseum,
        [MapValue("Campo de Futbol de Vallecas")]
        CampoDeFutbolDeVallecas,
        [MapValue("Montilivi")]
        Montilivi
    }
}
