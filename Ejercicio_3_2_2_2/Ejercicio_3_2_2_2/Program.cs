using System;

namespace Ejercicio_3_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio = 0;
            float pi = 3.14f;

            Console.WriteLine("Introduce el radio del circulo");
            radio = Convert.ToInt32(Console.ReadLine());

            float area = (pi * (radio * radio));
            Console.Write("El area del circues de de :{0}", area);
        }
    }
}
