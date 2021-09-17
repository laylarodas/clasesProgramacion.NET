using System;

namespace MasEjerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Crear un proyecto de consola:
                 a. Pedir al usuario la cantidad de números que desea ingresar.
                 b. Crear un array del tamaño que ingresó el usuario.
                 c. Cargar el array secuencialmente.
                 d. Mostrar el contenido del array
                 e. Informar:
                       i. El número mayor y el menor.
                      ii. La suma de todos los números.
                     iii. El promedio.
                 f. Pedir al usuario la posición de un elemento y eliminarlo.
                 g. Mostrar el contenido del array.
            //*/


            //Console.WriteLine("Cuantos numeros desea ingresar?");
            //int cantNum = Int32.Parse(Console.ReadLine());
            //double[] numeros = new double[cantNum];
            //double mayor = double.MinValue;
            //double menor = double.MaxValue;
            //double sumatoria = 0;
            //double promedio;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Random rd = new Random();
            //    rd.Next();
            //    numeros[i] = rd.Next(1, 101);
            //    if (menor > numeros[i])
            //    {
            //        menor = numeros[i];
            //    }
            //    if (mayor < numeros[i])
            //    {
            //        mayor = numeros[i];
            //    }
            //    sumatoria += numeros[i];
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write(numeros[i] + " ");
            //}

            //promedio = sumatoria / cantNum;

            //Console.WriteLine("\nEl numero mayor es: {0}", mayor);
            //Console.WriteLine("El numero menor es: {0}", menor);
            //Console.WriteLine("La suma de todos los numeros es: {0}", sumatoria);
            //Console.WriteLine("El promedio de todos los numeros es: {0}", promedio);

            //Console.WriteLine("Que posicion desea eliminar?");
            //int posicion = Int32.Parse(Console.ReadLine());

            

            //for (int i = posicion; i < numeros.Length; i++)
            //{
            //    if (i+1 < numeros.Length)
            //    {
            //        numeros[i] = numeros[i + 1];
            //    }
            //}
            //cantNum--;

            //for (int i = 0; i < cantNum; i++)
            //{
            //    Console.Write(numeros[i] + " ");
            //}


            /*2. Crear un proyecto de consola que permita cargar 5 nombres de personas y sus edades respectivas.
                 a. Realizar la carga pidiendo los datos al usuario.
                 b. Imprimir los nombres de las personas junto con su edad.
                 c. Informar cuántos mayores de edad (mayores o iguales a 18 años) y mostrar sus nombres.
                 d. Mostrar los nombres en orden ascendente por edad.
            */

            Console.WriteLine("Ingresar 5 nombres ");
            string[] nombres = new string[5];
            int[] edades = new int[5];
            //string nombreMin;
            //string nombreMax;
            //int min = int.MaxValue;
            //int max = int.MinValue;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();
                for (int j = 0; j < edades.Length; j++)
                {
                    Console.WriteLine("Ingrese edad:");
                    edades[j] = Int32.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < nombres.Length; i++)
            {
                for (int j = 0; j < edades.Length; j++)
                {
                    Console.WriteLine($"Nombre: {nombres[i]} Edad: {edades[j]}");
                }
            }

            Console.ReadKey();
        }
    }
}
