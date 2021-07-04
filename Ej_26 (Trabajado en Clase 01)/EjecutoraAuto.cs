using System;

namespace Ej_26__Trabajado_en_Clase_01_
{
    class EjecutoraAuto
    {
        static void Main(string[] args)
        {
            // variables definidas por un programa usuario
            Console.WriteLine("La máquina de crear autos");

            // para crear un autos es necesario instanciar objetos de la clase auto
            Auto primerAuto = new Auto();
            primerAuto.Bateria = "Sin mantenimiento 12V 75A";
            primerAuto.Chasis = "Acero";
            primerAuto.Espejo = "Automatico sin sensores";
            primerAuto.Luces = "Led";
            primerAuto.Motor = 2;
            primerAuto.Rueda = 5;
            primerAuto.Volante = 25;

            //
            Auto segundoAuto = new Auto(); // este momento se llama instanciación - creacion del objeto
            segundoAuto.Bateria = "Sin mantenimiento Litio";
            segundoAuto.Chasis = "Fibra de carbono";
            segundoAuto.Espejo = "Automatico Con sensores";
            segundoAuto.Luces = "Led con direccion";
            segundoAuto.Motor = 20;
            segundoAuto.Rueda = 5;
            segundoAuto.Volante = 250;
            // otra forma de setear un valor es llamando al método Set que a diferencia de los anteriores no se pasa como una propiedad
            segundoAuto.Carroceria(1323121321);


            //Muestre los datos que se proporcionan de forma predeterminada para un auto
            Console.WriteLine("DATOS DEL PRIMER AUTO");

            Console.WriteLine(primerAuto);
            Console.WriteLine(primerAuto.DatosDelAuto());
            Console.WriteLine("\n\n");
            Console.WriteLine("DATOS DEL SEGUNDO AUTO");
            Console.WriteLine(segundoAuto);
            Console.WriteLine(segundoAuto.DatosDelAuto());
            Console.ReadKey(true);
        }
    }
}
