using System;

namespace EjercicioPalabraInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba el código necesario para invertir las letras de cada palabra existente en la variable 'texto' y
             * muestre el resultado. En otras palabras, no vamos a revertir simplemente cada letra de la variable 'texto',
             * sino que invertiremos las letras de cada palabra, pero las palabras con los caracteres desordenados se imprimirán 
             * en su posición original dentro del mensaje.
             Por ejemplo: 
                             string texto = "Hola Mundo". Si todo va bien, debería aparecer la siguiente salida. 
                               
                                           // aloH odnuM
            */

            string texto = "Hola Mundo";
            string[] palabras = texto.Split(" ");
            //split() devuelve un array de palabras a partir de dividirlas por el caracter que pongamos en el parentesis

            string[] palabrasInvertidas = new string[palabras.Length];

            for (int i = 0; i < palabras.Length; i++)
            {
                char[] letras = palabras[i].ToCharArray();
                //toCharArray convierte la palabra en un array de caracteres, que guardamos en char[]letras;
                Array.Reverse(letras);
                //Array.Reverse da vuelta el array
                palabrasInvertidas[i] = new string(letras);
                //new string(letras) convierte cada array de letras(cada palabra) en un string que guardamos en el array palabrasInvertidas
            }

            string resultado = string.Join(" ", palabrasInvertidas);
            Console.WriteLine(texto);
            Console.WriteLine(resultado);

        }
    }
}
