using System;

namespace EjemploSingleton
{
    // Clase Singleton
    public class Persona
    {
        // Instancia única
        private static readonly Persona _instance = new Persona();

        // Propiedades de ejemplo
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructor privado
        private Persona()
        {
            Nombre = "Juan";
            Apellido = "Perez";
        }

        // Método para obtener la instancia
        public static Persona Instance
        {
            get
            {
                return _instance;
            }
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Accedemos al Singleton
            var persona1 = Persona.Instance;
            persona1.MostrarInformacion();

            // Cambiamos propiedades
            persona1.Nombre = "Pedro";
            persona1.Apellido = "Paez";

            // Desde otro acceso
            var persona2 = Persona.Instance;
            persona2.MostrarInformacion();

            // Verificamos que es el mismo objeto
            Console.WriteLine(Object.ReferenceEquals(persona1, persona2)); // True
        }
    }
}
