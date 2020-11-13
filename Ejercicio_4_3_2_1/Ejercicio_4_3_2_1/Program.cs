using System;

namespace Ejercicio_4_3_2_1
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
                    tipoCancion[] cancion = new tipoCancion[100];
                    int posicion = 0;
                int capacidad = 100;
                char opcion;

                do
                {
                    Console.WriteLine("Opción 1: Añadir una nueva canción");
                    Console.WriteLine("Opción 2: Mostrar el título de todas las canciones");
                    Console.WriteLine("Opción 3: Buscar la canción que contenga un cierto texto (en el artista o en el título)");
                    Console.WriteLine();


                    Console.Write("Escoge una opción:");
                    opcion = Convert.ToChar(Console.ReadLine());

                    switch (opcion)
                    {
                        case '1':
                            if (posicion < capacidad)
                            {
                                Console.Write("Artista:");
                                string nombreArtista = Console.ReadLine();
                                cancion[posicion].artista = nombreArtista;
                                


                                Console.Write("Titulo:");
                                string nombreTitulo = Console.ReadLine();
                                cancion[posicion].titulo = nombreTitulo;
                                


                                Console.Write("Tiempo:");
                                double nombreTiempo = Convert.ToDouble(Console.ReadLine());
                                cancion[posicion].tiempo = nombreTiempo;
                                

                                Console.Write("Tamaño:");
                                double nombreTamano = Convert.ToDouble(Console.ReadLine());
                                cancion[posicion].tamano = nombreTamano;
                                posicion++;
                            }
                            else
                            {
                                Console.WriteLine("lleno");
                            }
                            break;
                        case '2':
                            for (int i = 0; i < posicion; i++)
                            {
                                Console.WriteLine("titulo {0}:{1}", i + 1,cancion[i].titulo);
                                Console.WriteLine();
                            }
                            break;
                        case '3':
                            Console.Write("Buscar la canción (en el artista o en el título):");
                            string buscar = Console.ReadLine();

                            for (int i = 0; i < posicion; i++)
                            {
                                if (cancion[i].artista == buscar || cancion[i].titulo == buscar)
                                {
                                    Console.WriteLine(cancion[i].artista);
                                    Console.WriteLine(cancion[i].titulo);
                                    Console.WriteLine(cancion[i].tiempo);
                                    Console.WriteLine(cancion[i].tamano);
                                    Console.WriteLine();
                                }
                            }
                            break;
                    }
                    Console.WriteLine();
                }
                while (opcion != 's');
                
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato incorrecto");
                }
            
        }
    }
}
