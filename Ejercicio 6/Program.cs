using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el arreglo
            int[] nums = new int[0];
            int contador=0, num=0;
            char respuesta;
            do
            {

                //solicitamos el numero
                Console.Write("Ingrese un número: ");



                while (!int.TryParse(Console.ReadLine(), out num))
                {

                    Console.Write("El número ingresado no es entero: ");
                    

                }

                Array.Resize(ref nums, contador + 1);
                nums[contador] = num;

                do
                {
                    Console.Write("Desea seguir registrando? [s/n]: ");
                    respuesta = char.Parse(Console.ReadLine());
                }
                while (respuesta != 's' && respuesta != 'n');

                Console.Write("\n");
                contador++;

            }
            while (respuesta == 's');

            Console.WriteLine("El arreglo con los números ingresados es: ");
            foreach(int n in nums) { Console.WriteLine(n); }


            
        }
    }
}
