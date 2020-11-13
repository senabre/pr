using System;

namespace practica_1_1
{
    class Program
    {
        static void Main(string[] args)
        // --------------------------------------------
        // Andrés Senabre Gosalbez
        // Curso DAW
        // Modalidad Presencial
        // Práctica nº 1
        // --------------------------------------------
        {
            double segundoNumero = -1;
            char operacion;
            double resultado = 0;

            try
            {
                Console.Write("Introduce un número:");
                resultado = Convert.ToDouble(Console.ReadLine());
                do
                {

                    Console.Write("Introduce una operación:");
                    operacion = Convert.ToChar(Console.ReadLine());

                    switch (operacion)
                    {
                        case '+':
                            Console.Write("Introduce un número:");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());

                            resultado += segundoNumero;
                            break;
                        case '-':
                            Console.Write("Introduce un número:");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());

                            resultado -= segundoNumero;
                            break;
                        case '*':
                            Console.Write("Introduce un número:");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());

                            resultado *= segundoNumero;
                            break;
                        case '/':
                            Console.Write("Introduce un número:");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());

                            resultado /= segundoNumero;
                            break;
                        case '=':
                            Console.WriteLine("El resultado es {0}", resultado);
                            Console.WriteLine();

                            resultado = 0;
                            Console.Write("Introduce un número:");
                            resultado = Convert.ToDouble(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("--> Operación incorrecta");
                            break;
                    }

                }


                    while (operacion != 's');
                    {
                        Console.WriteLine("El resultado es {0}", resultado);
                        Console.WriteLine();
                        Console.WriteLine("FIN DEL PROGRAMA");
                        resultado = 0;
                    }

            }
           catch (FormatException)
           {
               Console.WriteLine("--> Número incorrecto");
           }
            
        }
        }
}
