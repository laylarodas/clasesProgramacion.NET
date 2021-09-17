using System;

namespace EjerciciosEstructurasRepetitivasFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*32. mostrar 10 repeticiones con números ASCENDENTE, desde el 1 al 10.
              33. mostrar 10 repeticiones con números , desde el 10 al 1.
              34. pedir la cantidad de veces que quiero repetir el mensaje "Hola Mundo"
              35. pedir un número. mostrar los números pares desde el 1 al número ingresado, y mostrar la cantidad de números 
                  pares encontrados.
              36. pedir un número. mostrar los números divisores desde el 1 al número ingresado, y mostrar la cantidad de números 
                  divisores encontrados.
              37. pedir un número. Informar si el número es PRIMO o no.
            */

            ////Ejercicio 32
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////Ejercicio 33
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            ////Ejercicio 34

            //Console.WriteLine("Ingrese cantidad de repeticiones: ");
            //int cantidad = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine("Hola Mundo");
            //}

            ////Ejercicio 35

            //Console.WriteLine("Ingrese un numero: ");
            //int numero = Int32.Parse(Console.ReadLine());
            //int cantPares = 0;
            //for (int i = 1; i <= numero; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        cantPares++;
            //    }
            //}
            //Console.WriteLine("La cantidad de pares encontrados es: {0}",cantPares);


            ////Ejericio 36

            //Console.WriteLine("Ingrese un numero");
            //int numero = Int32.Parse(Console.ReadLine());
            //int cantDiv = 0;
            //for (int i = 1; i <= numero; i++)
            //{
            //    if (numero % i == 0 )
            //    {
            //        Console.WriteLine(i);
            //        cantDiv++;
            //    }
            //}
            //Console.WriteLine("La cantidad de divisores es: {0}",cantDiv);

            //Ejercicio 37

            Console.WriteLine("Ingrese un numero");
            int numero = Int32.Parse(Console.ReadLine());
            int cantDiv = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cantDiv++;
                }
            }
            if (cantDiv == 2)
            {
                Console.WriteLine("Es numero primo");
            }
            else
            {
                Console.WriteLine("No es numero primo");
            }
        }
    }
}
