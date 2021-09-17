using System;

namespace EjercicioCaraCruz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usar la clase Random para generar un valor. 
              Segun el valor utilizar el operador condicional para mostrar “Cara” o “Cruz”. 
              Debe haber un 50% de probabilidad que el resultado sea cara o cruz.
            */
            string opcion;
            bool flag = true;

            do
            {
                Console.WriteLine("Desea lanzar una moneda? s/n");
                opcion = Console.ReadLine();
                if (opcion == "s")
                {
                    Random rd = new Random();
                    rd.Next();
                    int numero = rd.Next(1, 100);
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Salio cara", numero);
                       
                    }
                    else
                    {
                        Console.WriteLine("Salio cruz", numero);
          
                    }


                }
                else
                {

                    Console.WriteLine("Adios");
                    flag = false;
                }

            } while (flag);
            

        }
    }
}
