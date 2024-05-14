using System.Text.Json.Serialization;

namespace EjercicioClase1Modulo2
{
    internal class Persona
    {
        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }

        [JsonPropertyName("amigos_usuario")]
        public string[] Amigos { get; set; }

        [JsonPropertyName("notificaciones_usuario")]
        public bool NotificacionesUsuario { get; set; }

    }
}
