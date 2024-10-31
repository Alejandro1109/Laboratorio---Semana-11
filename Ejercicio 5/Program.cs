using System;


namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index;
            char remplazar;

            //creamos el arreglo
            char[] caracteres = { 'a', 'e', 'i', 'o', 'u' };

            //Mostramos la lista original
            Console.WriteLine("Lista original: ");
            foreach(char i in caracteres)
            { Console.WriteLine(i); }

            //Preguntamos cual caracter se desea modificar
            Console.Write("\nIngrese el carácter que desea modificar: ");
            remplazar = char.Parse(Console.ReadLine());

            //Identificamos el index del caracter pedido
            index = Array.IndexOf(caracteres, remplazar);

            //Modificamos el caracter si es que existe en la lista
            if (index != -1)
            {
                Console.Write($"Ingrese el carácter por el cual desea modificar '{remplazar}': ");
                caracteres[index] = char.Parse(Console.ReadLine());

                Console.WriteLine("\nLista modificada: ");
                foreach(char i in caracteres) { Console.WriteLine(i); }

            }
            else { Console.WriteLine("\nEl carácter que ingreso no existe en la lista."); }

            Console.ReadKey();




        }
    }
}
