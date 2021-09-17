using System;

namespace EjerciciosEstructurasRepetitivasWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*22. mostrar 10 repeticiones con números ASCENDENTE, desde el 1 al 10.
              23. mostrar 10 repeticiones con números DESCENDENTES, desde el 10 al 1.
              24. pedir al usuario la CLAVE (ayuda: es .NET)
              25. pedir un número entre 0 y 9 inclusive.
              26. pedir un sexo 'f' para femenino, 'm' para masculino.
              27. pedir 5 números e informar la suma acumulada y el promedio.
              28. pedir números hasta que el USUARIO QUIERA e informar la suma acumulada y el promedio.
              29. pedir números hasta que el usuario quiera, sumar los que son positivos y multiplicar los negativos.
              30. pedir números hasta que el usuario quiera, mostrar el número máximo y el número mínimo ingresado.
              31. pedir números hasta que el usuario quiera, mostrar:
                  1-Suma de los negativos.
                  2-Suma de los positivos.
                  3-Cantidad de positivos.
                  4-Cantidad de negativos.
                  5-Cantidad de ceros.
                  6-Cantidad de números pares.
                  7-Promedio de positivos.
                  8-Promedios de negativos.
                  9-Diferencia entre positivos y negativos, (positivos-negativos).
            */

            ////Ejericio 22

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            ////Ejericio 23
            //int i = 10;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            ////Ejericio 24

            //string clave;
            //do
            //{
            //    Console.WriteLine("Ingrese la clave: ");
            //    clave = Console.ReadLine();

            //} while (clave != ".NET");

            //Console.WriteLine("Clave correcta.");

            ////Ejercicio 25
            //int numero;

            //do
            //{
            //    Console.WriteLine("Ingrese un numero del 0 al 9 inclusive: ");
            //    numero = Int32.Parse(Console.ReadLine());

            //} while (numero < 0 || numero > 9);

            //Console.WriteLine("El numero ingresado es: {0}", numero);


            ////Ejericio 26

            //string sexo = "";
            //do
            //{
            //    Console.WriteLine("Ingrese sexo: f(femenimo) o m (masculino)");
            //    sexo = Console.ReadLine();

            //} while (!(sexo == "f" || sexo == "m"));

            //Console.WriteLine("El sexo ingresado es: {0}", sexo);


            ////Ejercicio 27

            //int i = 1;
            //double numero = 0;
            //double acumulador = 0;
            //double promedio = 0;
            //while (i <= 5)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = double.Parse(Console.ReadLine());
            //    acumulador += numero;
            //    i++;
            //}

            //promedio = acumulador / (i-1);

            //Console.WriteLine("La suma de los numeros ingresados es: {0}", acumulador);
            //Console.WriteLine("El promedio de los numeros ingresados es: {0}", promedio);

            ////Ejercicio 28


            //string opcion = "";
            //double acumulador = 0;
            //double numero = 0;
            //int contador = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = double.Parse(Console.ReadLine());
            //    acumulador += numero;
            //    contador++;
            //    Console.WriteLine("Desea seguir ingresando numeros? s/n");
            //    opcion = Console.ReadLine();
            //} while (!(opcion == "n"));

            //double promedio = acumulador / contador;
            //Console.WriteLine("La suma de los numeros ingresados es : {0}", acumulador);
            //Console.WriteLine("El promedio de los numeros ingresados es: {0}", promedio);

            ////Ejercicio 29

            //double numero;
            //double positivos = 0;
            //double negativos = 1;
            //string opcion;

            //do
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    numero = double.Parse(Console.ReadLine());
            //    if (numero > 0)
            //    {
            //        positivos += numero;
            //    }
            //    else
            //    {
            //        negativos *= numero;
            //    }
            //    Console.WriteLine("Desea seguir ingresando numeros? s/n");
            //    opcion = Console.ReadLine();
            //} while (!(opcion == "n"));

            //Console.WriteLine("La suma de los numeros positivos es: {0}",positivos);
            //Console.WriteLine("La multiplicacion de los numeros negativos es: {0}", negativos);

            ////Ejercicio 30

            //int min = int.MaxValue;
            //int max = int.MinValue;
            //int numero;
            //string opcion;

            //do
            //{
            //    Console.WriteLine("Ingrese un numero:");
            //    numero = Int32.Parse(Console.ReadLine());

            //    if (min > numero)
            //    {
            //        min = numero;
            //    }
            //    if (max < numero)
            //    {
            //        max = numero;
            //    }

            //    Console.WriteLine("Desea seguir ingresando numeros? s/n");
            //    opcion = Console.ReadLine();
            //} while (!(opcion == "n"));

            //Console.WriteLine("El numero minimo ingresado es: {0}", min);
            //Console.WriteLine("El numero maximo ingresado es: {0}", max);



            //Ejercicio 31
           
            string opcion;
            double numero;
            double sumaPos = 0, sumaNeg = 0;
            int cantPos = 0, cantNeg = 0, cantCeros = 0, pares = 0;
            double promPos, promNeg, difPosNeg;

            do
            {
                Console.WriteLine("Ingrese un numero :");
                numero = double.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    sumaPos += numero;
                    cantPos++;
                }
                if (numero == 0)
                {
                    cantCeros++;
                }
                if (numero < 0)
                {
                    sumaNeg += numero;
                    cantNeg++;
                }
                if (numero % 2 == 0)
                {
                    pares++;
                }
                Console.WriteLine("Desea seguir ingresando numeros? s/n");
                opcion = Console.ReadLine();
            } while (!(opcion == "n"));

            promPos = sumaPos / cantPos;
            promNeg = sumaNeg / cantNeg;
            difPosNeg = sumaPos - sumaNeg;

            Console.WriteLine("Cantidad de positivos: {0}", cantPos);
            Console.WriteLine("Cantidad de negativos: {0}", cantNeg);
            Console.WriteLine("Cantidad de ceros: {0}", cantCeros);
            Console.WriteLine("Cantidad de pares: {0}", pares);
            Console.WriteLine("Suma de numeros positivos es: {0}", sumaPos);
            Console.WriteLine("Suma de numeros negativos es: {0}", sumaNeg);
            Console.WriteLine("Promedio de numeros positivos es: {0}", promPos);
            Console.WriteLine("Promedio de numero negativos es:{0}", promNeg);
            Console.WriteLine("Diferencia entre numero positivos y negativos es: {0}", difPosNeg);









            Console.ReadKey();
        }
    }
}
