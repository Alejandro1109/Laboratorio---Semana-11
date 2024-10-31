using System;

namespace Practica___Semana_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            metodosLibreria Libreria = new metodosLibreria();

            do
            {

                Console.WriteLine("-------------Libreria-------------");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Mostrar libros");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar libro");
                Console.WriteLine("0. Salir");
                Console.WriteLine("----------------------------------");

                Console.Write("\nIngrese una opción: ");
                while (!byte.TryParse(Console.ReadLine(), out opcion))
                { Console.Write("Ingrese una opción valida: "); }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Libreria.registrar();
                        opcion = 6;
                        break;
                    case 2:
                        Libreria.mostrar();
                        break;
                    case 3:
                        Libreria.buscar();
                        break;
                    case 4:
                        Libreria.modificar();
                        break;
                }
            }
            while (true);

            
        }
    }
}
