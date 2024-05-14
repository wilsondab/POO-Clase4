using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class ArrProductos
    {
        [JsonPropertyName("productos")]
        public Producto[] Productos { get; set; }
    }

    public class Producto
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("existencias")]
        public int Existencias { get; set; }

        [JsonPropertyName("descuento_disponible")]
        public bool DescuentoDisponible { get; set; }

        [JsonPropertyName("etiquetas")]
        public string[] Etiquetas { get; set; }

        [JsonPropertyName("detalles")]
        public DetallesProducto Detalles { get; set; }
    }

    public class Dimensiones
    {
        [JsonPropertyName("alto")]
        public int Alto { get; set; }

        [JsonPropertyName("ancho")]
        public int Ancho { get; set; }

        [JsonPropertyName("profundidad")]
        public int Profundidad { get; set; }
    }

    public class DetallesProducto
    {
        [JsonPropertyName("peso")]
        public double Peso { get; set; }

        [JsonPropertyName("dimensiones")]
        public Dimensiones Dimensiones { get; set; }
    }
}
