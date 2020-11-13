using System;

namespace Ejercicio_3_2_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "a";
            int n1 = 0;
            try
            {
                Console.WriteLine("Introduce un numero en binario:");
                dato = Console.ReadLine();

                while (dato != "fin")
                {
                    n1 = Convert.ToInt32(dato, 2);

                    Console.WriteLine(Convert.ToString(n1, 10));
                    Console.WriteLine(Convert.ToString(n1, 16));

                    Console.WriteLine("Introduce un numero en binario:");
                    dato = Console.ReadLine();

                }
            }
            catch
            {
                Console.WriteLine("El numero tiene que ser binario");
            }
        }
    }
}
