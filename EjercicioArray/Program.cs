using System;

namespace EjercicioArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            int[] edades = new int[5];


            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                edades[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("{0} su edad es {1}", nombres[i], edades[i]);
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            string nombreMin = "";
            string nombreMax = "";

            for (int i = 0; i < nombres.Length; i++)
            {
                for (int j = 0; j < edades.Length; j++)
                {
                    if (min > edades[i])
                    {
                        min = edades[i];
                        nombreMin = nombres[i];
                    }
                    if (max < edades[i])
                    {
                        max = edades[i];
                        nombreMax = nombres[i];
                    }
                }
            }

            Console.WriteLine("El menor de las edades es: {0} - {1}",min,nombreMin);
            Console.WriteLine("El mayor de las edades es: {0} - {1}",max,nombreMax);
        }
    }
}
