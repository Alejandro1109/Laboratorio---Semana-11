using System;


namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el arreglo con sus items
            string[] nombres = { "Jose", "Oscar", "Carmen", "Alexa" };

            //solicitamos que se ingrese el nombre a buscar
            Console.Write("Ingrese un nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();

            //Verificamos que el nombre existe y guardamos su index
            int index = Array.IndexOf(nombres, nombreBuscar);

            //Mostramos el arreglo
            Console.WriteLine("Lista:");
            foreach(string i in nombres) { Console.WriteLine(i); }

            //mostramos el index del dato si que es existe
            if (index != -1)
            {
                Console.WriteLine($"\nEl nombre que busco está en el index {index}. ");
            }
            else { Console.WriteLine("\nEl nombre que busco no está en la lista. "); }

            Console.ReadKey();



        }
    }
}
