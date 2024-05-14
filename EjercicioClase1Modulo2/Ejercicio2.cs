using System.Text.Json.Serialization;

namespace EjercicioClase1Modulo2
{
    internal class Estadistica
    {
        [JsonPropertyName("estadistica")]
        public Equipo[] Estadisticas { get; set; }
    }

    internal class Jugador
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("death")]
        public int Death { get; set; }
    }

    internal class Equipo
    {
        [JsonPropertyName("equipo")]
        public string Nombre { get; set; }

        [JsonPropertyName("jugadores")]
        public Jugador[] Jugadores { get; set; }

        [JsonPropertyName("campeon")]
        public bool Campeon { get; set; }
    }
}
