using System;


namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos el arreglo
            int[] numeros = {1, 2, 3, 4, 5}; 

            //Mostramos sus items
            foreach(int numero in numeros)
            { Console.WriteLine(numero); }


            Console.ReadKey();

        }
    }
}
