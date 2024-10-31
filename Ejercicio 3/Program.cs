using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el arreglo
            int[] num = { 4, 8, 10, 25 };

            //Mostramos la lista original
            Console.WriteLine("Lista original: ");
            foreach(int i in num) { Console.WriteLine(i); }

            //Modificamos el valor 10
            num[2] = 36;

            //Mostramos la lista modificada
            Console.WriteLine("\nLista modificada: ");
            foreach (int i in num) { Console.WriteLine(i); }

            Console.ReadKey();

        }
    }
}
