using System;

namespace Ej_27__Trabajado_en_Clase_02_
{
    class EjecutoraTaxi
    {
        static void Main(string[] args)
        {
            // variables para utilizar el constructor paramétrico
            int caducidad = 0;
            int licencia = 0;
            string patente = "";

            Console.WriteLine("Ingrese los valores para el primer taxi");
            Taxi objtaxi1 = new Taxi();
            Console.WriteLine("Ingrese los valores para el segundo taxi");
            Taxi objtaxi2 = new Taxi();

            /*---------------------------------------------------------*/
            /* SIMULO QUE LOS DATOS SON PROVISTOS DESDE UNA INTERFACE NO CONSOLA*/
            /*---------------------------------------------------------*/

            Console.WriteLine("Ingrese los valores para el tercer taxi");
            Console.WriteLine("Ingrese la patente:");
            patente = Console.ReadLine();
            Console.WriteLine("Ingrese la licencia:");
            licencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la caducidad:");
            caducidad = int.Parse(Console.ReadLine());
            Taxi objtaxi3 = new Taxi(patente, licencia, caducidad);

            Console.WriteLine("Defina un valor para la bajada de bandera");
            objtaxi3.BajadaDeBandera = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los valores para el cuarto taxi");
            Console.WriteLine("Ingrese a continuación los valores para patente, licencia y caducidad una a continuacion del otro, presionando enter entre cada uno de los valores");

            Taxi objtaxi4 = new Taxi(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));




            Console.WriteLine($"Taxi 1\t{objtaxi1}");
            Console.WriteLine($"Taxi 2\t{objtaxi2}");
            Console.WriteLine($"Taxi 3\t{objtaxi3}");
            Console.WriteLine($"Taxi 4\t{objtaxi4}");

            Console.WriteLine($"La cantidad de taxis creados es: {objtaxi1.CantidadDeTaxisCreados()}");
            Console.WriteLine($"La cantidad de taxis creados es: {objtaxi2.CantidadDeTaxisCreados()}");
            // Console.WriteLine($"La cantidad de taxis creados es: {Taxi.CantidadDeTaxisCreados()}");
        }
    }
}
