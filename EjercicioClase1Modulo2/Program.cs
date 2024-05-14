using System;
using System.Text.Json;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            Persona persona = JsonSerializer.Deserialize<Persona>(dataEjercicio1);
            Console.WriteLine("Persona: ");
            Console.WriteLine("  Nombre: " + persona.Usuario);
            Console.WriteLine("  Amigos: ");

            foreach (var elemento in persona.Amigos)
            {
                Console.WriteLine("   "+elemento);
            }

            Console.WriteLine("  Notificaciones: " + persona.NotificacionesUsuario);


            Estadistica estadisticas = JsonSerializer.Deserialize<Estadistica>(dataEjercicio2);
            Console.WriteLine("--------------------");
            foreach (var equipo in estadisticas.Estadisticas)
            {
                Console.WriteLine("Equipo: ");
                Console.WriteLine("  Nombre: " + equipo.Nombre);
                Console.WriteLine("  Jugadores:");
                foreach (var jugador in equipo.Jugadores)
                {
                    Console.WriteLine("   Nombre: " + jugador.Nombre + ", Kills: " + jugador.Kills + ", Deaths: " + jugador.Death);
                }
                Console.WriteLine("  Campeon: " + equipo.Campeon);
            }


            ArrProductos arrProductos = JsonSerializer.Deserialize<ArrProductos>(dataEjercicio3);
            Console.WriteLine("--------------------");
            foreach (var producto in arrProductos.Productos)
            {
                Console.WriteLine("Producto:");
                Console.WriteLine("  Nombre: " + producto.Nombre);
                Console.WriteLine("  Precio: $" + producto.Precio);
                Console.WriteLine("  Existencias: " + producto.Existencias);
                Console.WriteLine("  Descuento Disponible: " + producto.DescuentoDisponible);
                Console.WriteLine("  Etiquetas:");
                foreach (var elemento in producto.Etiquetas)
                {
                    Console.WriteLine("   " + elemento);
                }
                Console.WriteLine("  Detalles:");
                Console.WriteLine("   Peso: " + producto.Detalles.Peso);
                Console.WriteLine("   Dimensiones:");
                Console.WriteLine("    Alto: " + producto.Detalles.Dimensiones.Alto + " Ancho: " 
                    + producto.Detalles.Dimensiones.Ancho + " Profundidad: " + producto.Detalles.Dimensiones.Profundidad);
                Console.WriteLine();
            }
        }
    }
}