using System;

namespace EjerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*38. mostrará 10 números que estarán contenidos en un vector.
              39. mostrará 5 nombres que estarán contenidos en un vector.
              40. se pedirá números que serán guardados en un vector y luego serán mostrados
              41. se pedirá números que serán guardados en un vector y luego serán mostrados. 
                  Además de la sumatoria de todos los números
            */

            ////Ejercicio 38

            //int[] miArray = new int[10];
            //for (int i = 0; i < miArray.Length; i++)
            //{
            //    Random rd = new Random();
            //    rd.Next();
            //    miArray[i] = rd.Next(1,100);

            //}
            //for (int i = 0; i < miArray.Length; i++)
            //{
            //    Console.Write(miArray[i] + " ");
            //}

            ////Ejericio 39

            //string[] nombres = { "Ana Maria", "Lucas", "Laura", "Federico", "Lucrecia"};

            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    Console.Write(nombres[i]+ " ");
            //}

            ////Ejericio 40

            //Console.WriteLine("Cuantos numeros desea mostrar?: ");
            //int cantNum = Int32.Parse(Console.ReadLine());
            //int[] numeros = new int[cantNum];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numeros[i] = Int32.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write(numeros[i]+ " ");
            //}

            //Ejercicio 41


            Console.WriteLine("Cuantos numeros desea mostrar?: ");
            int cantNum = Int32.Parse(Console.ReadLine());
            int[] numeros = new int[cantNum];
            int sumatoria = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros[i] = Int32.Parse(Console.ReadLine());
                sumatoria += numeros[i];
            }
            Console.WriteLine("Los numeros ingresados son: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine("\nLa sumatoria de los numeros ingresados es: {0}", sumatoria);
        }
    }
}
