using System;

namespace ConsoleFibonacciReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese posicion inicial");
            int posicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese posiciones a mostrar hacia atras");
            int posiciones = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[] fi = new int[posicion];
            fi[0] = 0;
            fi[1] = 1;
            for (int i = 2; i < posicion; i++)
            {
                fi[i] = fi[i - 2] + fi[i - 1];

            }
            Console.Write("Sucesión de Fibonacci de reversa posicion inicial: " + posicion + ", posicion final: " + (posicion - posiciones) + "\n");
            for (int i = posicion - 1; i > posiciones; i--)
            {
                Console.Write(fi[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
