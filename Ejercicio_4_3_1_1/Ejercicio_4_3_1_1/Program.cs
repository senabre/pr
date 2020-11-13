using System;

namespace Ejercicio_4_3_1_1
{
    struct tipoCancion
    {
        public string artista;
        public string titulo;
        public double tiempo;
        public double tamano;
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                tipoCancion cancion;
                Console.Write("Artista de la canción:");
                cancion.artista = Console.ReadLine();

                Console.Write("Titulo de la canción:");
                cancion.titulo = Console.ReadLine();

                Console.Write("Tiempo de la canción:");
                cancion.tiempo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tamaño de la canción:");
                cancion.tamano = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine();

                Console.WriteLine("Artista: {0}", cancion.artista);
                Console.WriteLine("Titulo: {0}", cancion.titulo);
                Console.WriteLine("Tiempo: {0}", cancion.tiempo);
                Console.WriteLine("Tamaño: {0}", cancion.tamano);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato incorrecto");
            }
        }
    }
}
