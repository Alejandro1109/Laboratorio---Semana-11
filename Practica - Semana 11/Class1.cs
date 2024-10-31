using System;
using System.Collections.Generic;
using System.Reflection;


namespace Practica___Semana_11
{
    internal class metodosLibreria
    {
        public int contador = 0;
        public string[] nombresLibros = new string[0];
        public double[] preciosLibros = new double[0];


        public void registrar()
        {
            char respuesta;
            double precio;

            do
            {

                Console.Write("Ingrese el nombre del libro que desea registrar: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del libro que desea registrar: ");
                while (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                {
                    Console.Write("Ingrese un precio válido: ");
                }

                //Aumentamos de tamaño los arreglos
                Array.Resize(ref nombresLibros, contador + 1);
                Array.Resize(ref preciosLibros, contador + 1);

                nombresLibros[contador] = nombre;
                preciosLibros[contador] = precio;


                Console.Write("\nDesea seguir registrando? [s/n]: ");
                respuesta = char.Parse(Console.ReadLine());
                Console.Clear();
                contador++;
            }
            while (respuesta == 's');

        }

        public void mostrar()
        {
            Console.Clear();

            Console.WriteLine("-------------Libros registrados-------------");

            Console.SetCursorPosition(0, 2);
            Console.Write("----------Libro-----");
            for (int i = 0; i < nombresLibros.Length; i++)
            {
                Console.SetCursorPosition(10, 3 + i);
                Console.Write(nombresLibros[i]);

            }
            Console.SetCursorPosition(16, 2);
            Console.Write("------------Precio----------");
            for (int i = 0; i < preciosLibros.Length; i++)
            {
                Console.SetCursorPosition(28, 3 + i);
                Console.Write(preciosLibros[i]);

            }

            Console.Write("\n\nDesea volver al menu? [s/n]: ");
            char respuesta = char.Parse(Console.ReadLine());
            if (respuesta == 's') { Console.Clear(); }
            else { Environment.Exit(0); }

        }

        public int buscar()
        {
            char buscar = ' ';
            int index;
            do
            {

                Console.Clear();
                Console.Write("Ingrese el nombre del libro que desea buscar: ");
                string libroBuscar = Console.ReadLine();

                index = Array.IndexOf(nombresLibros, libroBuscar);

                if (index == -1)
                {
                    Console.Write("\nEl libro buscado no existe.\nDesea buscar otro libro? [s/n]: ");
                    buscar = char.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine($"\nLibro: {nombresLibros[index]} - Precio: {preciosLibros[index]}");
                    Console.Write("Desea seguir buscando? [s/n]: ");
                    buscar = char.Parse(Console.ReadLine()); 
                }

            }
            while (buscar == 's');

            Console.Clear();
            return index;

        }

        public void modificar()
        {
            char buscar = ' ';
            int index;
            do
            {

                Console.Clear();
                Console.Write("Ingrese el nombre del libro que desea modificar: ");
                string libroBuscar = Console.ReadLine();

                index = Array.IndexOf(nombresLibros, libroBuscar);

                if (index == -1)
                {
                    Console.Write("El libro buscado no existe.\n Desea buscar otro libro? [s/n]: ");
                    buscar = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("\nIngrese el nuevo nombre: ");
                    nombresLibros[index] = Console.ReadLine();

                    Console.Write("Ingrese el nuevo precio: ");
                    while (!double.TryParse(Console.ReadLine(), out preciosLibros[index]) || preciosLibros[index] < 0)
                    {
                        Console.Write("Ingrese un precio válido: ");
                    }

                    Console.WriteLine("\nAquí está el libro con los datos modificados: ");
                    Console.WriteLine($"Libro: {nombresLibros[index]} - Precio: {preciosLibros[index]}");

                    Console.Write("Desea modificar otro libro? [s/n]: ");
                    buscar = char.Parse(Console.ReadLine());
                }

            }
            while (buscar == 's');

            Console.Clear();


        }




    }
}
