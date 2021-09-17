using System;

namespace EjerciciosEstructurasSelectivas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Pedir al usuario que ingrese su edad. Si la edad es 15 mostrar “Quinceañero/a”
              7. Al ingresar una edad informar si la persona es mayor de edad
              8. Al ingresar una edad debemos informar si la persona es mayor de edad sino informar que es menor
              9. Al ingresar una edad debemos informar si la persona es adolescente, edad entre 13 y 17 años (inclusive)
             10. Al ingresar una edad solo debemos informar si la persona NO es adolescente.
             11. Al ingresar una edad debemos informar si la persona es mayor de edad (mas de 18 años) o adolescente 
                (entre 13 y 17 años) o niño (menor a 13 años).
             12. Al ingresar una edad menor a 18 años y un estado civil distinto a "Soltero", mostrar el siguiente mensaje:
                 'Es muy pequeño para NO ser soltero.’
             13. Al ingresar una edad menor a 18 años y un estado civil distinto a "Soltero", NO HACER NADA, pero si no es asi, 
                 y es soltero y no es menor, mostrar el siguiente mensaje: 'Es soltero y no es menor.'
            //*/

            ////Ejercicio 6
            //Console.WriteLine("Ingrese su edad ");
            //int edad = Int32.Parse(Console.ReadLine());

            //if (edad == 15)
            //{
            //    Console.WriteLine("Quinceañero/a");
            //}

            ////Ejercicio 7
            //Console.WriteLine("Ingrese su edad: ");
            //int anios = Int32.Parse(Console.ReadLine());

            //if (anios >= 18)
            //{
            //    Console.WriteLine("Mayor de edad");
            //}

            ////Ejercicio 8
            //Console.WriteLine("Ingrese su edad: ");
            //int yearsOld = Int32.Parse(Console.ReadLine());
            //if (yearsOld >= 18)
            //{
            //    Console.WriteLine("Mayor de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Menor de edad ");
            //}

            ////Ejercicio 9

            //Console.WriteLine("Ingrese su edad:");
            //int old = Int32.Parse(Console.ReadLine());
            //if (old >= 13 && old <= 17)
            //{
            //    Console.WriteLine("Adolescente");
            //}

            ////Ejercicio 10
            //Console.WriteLine("Ingrese su edad:");
            //int old = Int32.Parse(Console.ReadLine());
            //if (!(old >= 13 && old <= 17))
            //{
            //    Console.WriteLine("No es Adolescente");
            //}


            ////Ejercicio 11

            //Console.WriteLine("Ingrese su edad: ");
            //int edad = Int32.Parse(Console.ReadLine());

            //if (edad < 13)
            //{
            //    Console.WriteLine("Menor de edad");
            //} else if (edad >= 13 && edad <= 17)
            //{
            //    Console.WriteLine("Adolescente");
            //}
            //else
            //{
            //    Console.WriteLine("Mayor de edad");
            //}

            ////Ejercicio 12
            //Console.WriteLine("Ingrese su edad:");
            //int edad = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese estado civil:");
            //string estadoCivil = Console.ReadLine();

            //if (edad < 18 && estadoCivil != "soltero")
            //{
            //    Console.WriteLine("Es muy pequeño para NO ser soltero.");
            //}

            //Ejercicio 13
            Console.WriteLine("Ingrese su edad:");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese estado civil:");
            string estadoCivil = Console.ReadLine();

            if (edad >= 18 && estadoCivil == "soltero")
            {
                Console.WriteLine("Es soltero y no es menor.");
            }


            Console.ReadKey();
        }
    }
}
