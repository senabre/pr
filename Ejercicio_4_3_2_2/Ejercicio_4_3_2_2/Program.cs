using System;

namespace Ejercicio_4_3_2_2
{
    struct tipoImagen
    {
        public string nombre;
        public int ancho;
        public int alto;
        public double tamano;
    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                tipoImagen[] cancion = new tipoImagen[700];
                int posicion = 0;
                int capacidad = 700;
                char opcion;
                int i = -1;

                do
                {
                    Console.WriteLine("Opción 1: Añadir una nueva imagen");
                    Console.WriteLine("Opción 2:  ver todas las fichas");
                    Console.WriteLine("Opción 3: Buscar la canción que contenga un cierto texto (en el artista o en el título)");
                    Console.WriteLine();


                    Console.Write("Escoge una opción:");
                    opcion = Convert.ToChar(Console.ReadLine());

                    switch (opcion)
                    {
                        case '1':
                            if (posicion < capacidad)
                            {
                                Console.Write("Nombre:");
                                string tipoNombre = Console.ReadLine();
                                cancion[posicion].nombre = tipoNombre;



                                Console.Write("Ancho en píxeles:");
                                int anchoPixeles = Convert.ToInt32(Console.ReadLine());
                                cancion[posicion].ancho = anchoPixeles;



                                Console.Write("Alto en píxeles:");
                                int altoPixeles = Convert.ToInt32(Console.ReadLine());
                                cancion[posicion].alto = altoPixeles;


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
                            for (int j = 0; j < posicion; j++)
                            {
                                Console.WriteLine("Nombre:{0}",cancion[j].nombre);
                                Console.WriteLine("Ancho de pixeles:{0}", cancion[j].ancho);
                                Console.WriteLine("Alto de pixeles:{0}", cancion[j].alto);
                                Console.WriteLine("Tamaño:{0}", cancion[j].tamano);
                                Console.WriteLine();
                            }
                            break;
                        case '3':
                            Console.Write("Buscar una imagen:");
                            string buscar = Console.ReadLine();

                            for (i = 0; i < posicion; i++)
                            {
                                if (cancion[i].nombre == buscar)
                                {
                                    Console.WriteLine(cancion[i].nombre);
                                    Console.WriteLine(cancion[i].ancho);
                                    Console.WriteLine(cancion[i].alto);
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
