using System;
using System.Runtime.InteropServices;


namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            //Pedimos que se ingrese la cantidad de numeros a generar
            Console.Write("Ingrese la cantidad de números aleatoarios a generar: ");
            int n = int.Parse(Console.ReadLine());

            //Creamos el arreglo
            int[] num = new int[n]; 

            //Generamos los numeros y los guardamos en el arreglo
            for (int i = 0; i < n; i++)
            {
                num[i] = rnd.Next(0, 51);
                Console.WriteLine($"Index {i}: {num[i]}");
            }

            Console.ReadKey();


        }
    }
}
