using System;

namespace EjerciciosEntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Pedir al usuario su nombre y mostrarlo por consola
              2. Pedir al usuario que ingrese su nombre y edad y mostrar “Usted es [nombre] y tiene [edad] años”
              3. Pedir al usuario que ingrese dos números, sumarlos y mostrar el resultado.
              4. Pedir al usuario que ingrese un número. Luego mostrar el importe con un aumento del 10%
              5. Pedir al usuario que ingrese un número. Luego mostrar el importe con un descuento del 25%
            */

            //Ejercicio 1
            Console.WriteLine("Ingrese su nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Su nombre es: {0}", name);

            //Ejercicio 2
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Usted es {0} y tiene {1} años.", nombre, edad);


            //Ejercicio 3
            Console.WriteLine("Ingrese dos numeros:");
            Console.WriteLine("Numero 1:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            double num2 = double.Parse(Console.ReadLine());

            double suma = num1 + num2;
            Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, suma);



            //Ejercicio 4 
            Console.WriteLine("Ingrese un numero al cual le aplicaremos un aumento del 10%: ");
            double numero = double.Parse(Console.ReadLine());
            double aumento = Math.Round((numero * 1.10), 2);

            Console.WriteLine("El numero ingresado con un aumento del 10% es: {0}", aumento);


            //Ejercicio 5
            Console.WriteLine("Ingrese un numero al cual le aplicaremos un descuento del 25%: ");
            double num = double.Parse(Console.ReadLine());
            double descuento = num * 0.25;
            double resultado = num - descuento;


            Console.WriteLine("El numero ingresado con un descuento del 25% es: {0}", resultado);


            Console.ReadKey();
        }
    }
}