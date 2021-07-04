using System;

namespace Ej_29__Trabajado_en_clase_04_
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BIENVENIDAS LAS HERENCIAS");
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;

            //INSTANCIAMOS UNA PUERTA
            Puerta objpuerta1 = new Puerta();
            //INTANCIAMOS UNA VENTANA
            Ventana objventana = new Ventana();
            //instanciamos otra puerta
            Puerta objpuerta2 = new Puerta();



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Datos de la puerta objpuerta1:\n\n{objpuerta1.ToString()}\n");
            Console.WriteLine($"Datos de la ventana objventana:\n\n{objventana.ToString()}\n");
            Console.WriteLine($"Datos de la puerta objpuerta2:\n\n{objpuerta2.ToString()}\n");

            //instanciamos otra puerta3
            Puerta objPuerta3 = new Puerta("Corrediza", 0); // este objeto lo instanciamos para usar el otro constructor declarado en la super clase aberturas

            // ahora me pide que muestre la cantidad de aberturas que se crearon!!!
            // puedo acceder a ellas mediante la clase madre (super clase) que contiene la variable cantidadaberturas (variable de clase)

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"La cantidad de aberturas creadas es: {Abertura.CantidadAberturas}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
