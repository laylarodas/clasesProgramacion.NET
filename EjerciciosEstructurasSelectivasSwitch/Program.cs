using System;

namespace EjerciciosEstructurasSelectivasSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*14. Pedir al usuario que ingrese un mes del año. si es Enero: "que comiences bien el año!!!." si es Marzo:
                  "a clases!!!." si es Julio: "se vienen las vacaciones!!!." si es Diciembre: "Felices fiesta!!!."
              15. Pedir al usuario que ingrese un mes del año. si estamos en Invierno: "Abrigate que hace frio.
                  "si aún no llego el Invierno: "Falta para el invierno." si ya paso el Invierno:"Ya pasamos el frio, 
                  ahora calor!!!." ACLARACIÓN: tomamos a Julio y Agosto como los meses de Invierno.
              16. Pedir al usuario que ingrese un mes del año. si es Febrero: " Este mes no tiene más de 29 días.
                  " si NO es Febrero: "Este mes tiene 30 o más días"
              17. Pedir al usuario que ingrese un mes del año informar. si tiene 28 días. si tiene 30 días.si tiene 31 días.
              18. Al ingresar una hora, informar: si está entre las 7 y las 11 : "Es de mañana.".
              19. Al ingresar una hora, informar: si está entre las 7 y las 11 : "Es de mañana.". si está entre las 12 y las 19: 
                  "Es de tarde.". si está entre las 20 y las 24 o entre las 0 y las 6 : "Es de noche.". si NO está entre las 0 y 
                   las 24 : "la hora no existe.".
              20. Una agencia de viajes debe sacar las tarifas de los viajes , se cobra $15.000 por cada estadía como base,
                  se pide el ingreso de una estación del año y localidad para vacacionar para poder calcular el precio final. 
                  En Invierno: bariloche tiene un aumento del 20% cataratas y Córdoba tiene un descuento del 10% Mar del plata
                  tiene un descuento del 20%. En Verano: bariloche tiene un descuento del 20% cataratas y Córdoba tiene un aumento
                  del 10% Mar del plata tiene un aumento del 20%. En Otoño y Primavera: bariloche tiene un aumento del 10% 
                  cataratas tiene un aumento del 10% Mar del plata tiene un aumento del 10% y Córdoba tiene el precio sin descuento.
              21. una agencia de viajes nos piden informar si hacemos viajes a lugares según la estación del año estemos, informar 
                  si "Se viaja" o "No se viaja" a ese lugar. En Invierno: Solo Bariloche informa "se viaja" los demás destinos
                  "No se viaja". En Verano: Se viaja a Mar del plata y Cataratas solamente. En Otoño: Se viaja a todos los destinos.
                  Primavera: solo no se viaja a Bariloche.
            */

            ////Ejercicio 14
            //Console.WriteLine("Ingrese un mes del año: ");
            //string mes = Console.ReadLine();
            //switch (mes)
            //{
            //    case "Enero":
            //        Console.WriteLine("Que comiences bien el año!!");
            //        break;
            //    case "Marzo":
            //        Console.WriteLine("A clases!!");
            //        break;
            //    case "Julio":
            //        Console.WriteLine("Se vienen las vacaciones!!!");
            //        break;
            //    case "Diciembre":
            //        Console.WriteLine("Felices Fiestas!!");
            //        break;
            //    default:
            //        Console.WriteLine(" ");
            //        break;
            //}

            ////Ejercicio 15
            //Console.WriteLine("Ingrese un mes del año:");
            //string mes = Console.ReadLine();

            //switch (mes)
            //{
            //    case "Enero":
            //    case "Febrero":
            //    case "Marzo":
            //    case "Abril":
            //    case "Mayo":
            //    case "Junio":
            //        Console.WriteLine("Falta para el invierno");
            //        break;
            //    case "Julio":
            //    case "Agosto":
            //        Console.WriteLine("Abrigate hace frio");
            //        break;
            //    case "Septiembre":
            //    case "Octubre":
            //    case "Noviembre":
            //    case "Diciembre":
            //        Console.WriteLine("Ya pasams el frio, ahora calor");
            //        break;
            //    default:
            //        Console.WriteLine("No ingreso un mes del año ");
            //        break;
            //}

            ////Ejercicio 16

            //Console.WriteLine("Ingrese un mes del año");
            //string mes = Console.ReadLine();

            //switch (mes)
            //{
            //    case "Febrero":
            //        Console.WriteLine("Este mes no tiene mas de 29 dias.");
            //        break;
            //    case "Enero":
            //    case "Marzo":   
            //    case "Abril":
            //    case "Mayo":
            //    case "Junio":
            //    case "Julio":
            //    case "Agosto":
            //    case "Septiembre":
            //    case "Octubre":
            //    case "Noviembre":
            //    case "Diciembre":
            //        Console.WriteLine("Este mes tiene 30 o más días");
            //        break;
            //    default:
            //        Console.WriteLine("No ingreso un mes del año");
            //        break;
            //}

            ////Ejercicio 17
            //string mes = Console.ReadLine();
            //switch (mes)
            //{
            //    case "Enero":
            //    case "Marzo":
            //    case "Mayo":
            //    case "Julio":
            //    case "Agosto":
            //    case "Octubre":
            //    case "Diciembre":
            //        Console.WriteLine("Tiene 31 días.");
            //        break;
            //    case "Abril":
            //    case "Junio":
            //    case "Septiembre":
            //    case "Noviembre":
            //        Console.WriteLine("Tiene 30 días.");
            //        break;
            //    case "Febrero":
            //        Console.WriteLine("Tiene 28 días.");
            //        break;
            //    default:
            //        Console.WriteLine("No ingreso un mes del año");
            //        break;
            //}

            ////Ejericio 18

            //Console.WriteLine("Ingrese una hora:");
            //int hora = Int32.Parse(Console.ReadLine());

            //if (hora > 7 && hora < 11)
            //{
            //    Console.WriteLine("Es de mañana ");
            //}


            ////Ejericio 19

            //Console.WriteLine("Ingrese una hora:");
            //int hora = Int32.Parse(Console.ReadLine());

            //if ((hora >= 20 && hora <= 24) || (hora >= 0 && hora <= 6))
            //{
            //    Console.WriteLine("Es de noche.");
            //}
            //else if ( hora >= 7 && hora <= 11)
            //{
            //    Console.WriteLine("Es de mañana");
            //} 
            //else if (hora >= 12 && hora <=19 )
            //{
            //    Console.WriteLine("Es de tarde");
            //}
            //else
            //{
            //    Console.WriteLine("La hora no existe");
            //}


            ////Ejercicio 20

            //Console.WriteLine("Ingrese estación del año y localidad para vacacionar: ");
            //Console.WriteLine("Estación:");
            //string estacion = Console.ReadLine();
            //Console.WriteLine("Localidad: ");
            //string localidad = Console.ReadLine();
            //double baseEstadia = 15000;
            //double precioFinal;

            //switch (estacion)
            //{
            //    case "Invierno":
            //        if (localidad == "Bariloche")
            //        {
            //            precioFinal = baseEstadia * 1.20;
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}",estacion,localidad,precioFinal);
            //        }
            //        else if (localidad == "Cataratas" || localidad == "Cordoba")
            //        {
            //            precioFinal = baseEstadia - (baseEstadia * 0.10);
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        } else if(localidad == "Mar del Plata")
            //        {
            //            precioFinal = baseEstadia - (baseEstadia * 0.20);
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        }
            //        break;
            //    case "Verano":
            //        if (localidad == "Bariloche")
            //        {
            //            precioFinal = baseEstadia - (baseEstadia * 0.20);
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        }
            //        else if (localidad == "Cataratas" || localidad == "Cordoba")
            //        {
            //            precioFinal = baseEstadia * 1.10;
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        }
            //        else if (localidad == "Mar del Plata")
            //        {
            //            precioFinal = baseEstadia * 1.20;
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        }
            //        break;
            //    case "Primavera":
            //    case "otoño":
            //        if (localidad == "Bariloche" || localidad == "Cataratas" || localidad == "Mar del Plata")
            //        {
            //            precioFinal = baseEstadia * 1.10;
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}", estacion, localidad, precioFinal);
            //        }
            //        else
            //        {
            //            precioFinal = baseEstadia;
            //            Console.WriteLine("El precio final en {0} en la localidad {1} es: {2}",estacion, localidad ,precioFinal);
            //            break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Necesitamos que ingrese una estacion del año y localidad para informar las tarifas de los viajes");
            //        break;
            //}

            //Ejercicio 21 


            Console.WriteLine("Ingrese estación del año y localidad para vacacionar: ");
            Console.WriteLine("Estación:");
            string estacion = Console.ReadLine();
            Console.WriteLine("Localidad: ");
            string localidad = Console.ReadLine();

            switch (estacion)
            {
                case "Invierno":
                    if (localidad == "Bariloche")
                    {
                        Console.WriteLine("Se viaja");
                    }
                    else
                    {
                        Console.WriteLine("No se viaja");
                    }

                    break;
                case "Verano":
                    if (localidad == "Mar del Plata" || localidad == "Cataratas")
                    {
                        Console.WriteLine("Se viaja");
                    }
                    else
                    {
                        Console.WriteLine("No se viaja");
                    }
                    break;
                case "Primavera":
                    if (localidad == "Bariloche")
                    {
                        Console.WriteLine("No se viaja");
                    }
                    else
                    {
                        Console.WriteLine("Se viaja");
                    }
                    break;
                case "Otoño":
                    Console.WriteLine("Se viaja");
                    break;
                default:
                    Console.WriteLine("Necesitamos que ingrese una estacion del año y localidad para informar si se puede viajar.");
                    break;
            }





            Console.ReadKey();
        }
    }
}
