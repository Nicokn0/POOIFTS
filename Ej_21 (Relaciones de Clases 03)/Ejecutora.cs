using System;
using System.Collections.Generic;

namespace Ej_21__Relaciones_de_Clases_03_
{
    class Ejecutora
    {
        /*
             3) Una empresa comercializa autos importados.
        
            Todo auto tiene marca, modelo, costo (en la moneda de origen), precio de venta (en pesos) y
        la cantidad de unidades en stock. La ganancia de cada auto se calcula restando el costo (debiendo 
        convertirlo de acuerdo a la cotización cargada) al precio de venta. 
        
        Además la empresa tiene una lista con las monedas 
        extranjeras con las que opera, de las que se conoce la denominación de la moneda y la cotización.
        
        Definir las clases 
        necesarias y escribir los métodos para programar los siguientes casos de uso: 

        a) Agregar stock de un auto, teniendo en cuenta que puede ser un nuevo auto que se comercializará en la 
        empresa o uno ya existente. 

        b) Agregar una nueva moneda con la que operará. 

        c) Informar la ganancia total que tendría la empresa en la venta de todos los autos que posee considerando 
        valor de costo y venta. 
         
         */
        static void Main(string[] args)
        {
            List<Moneda> ObjMoneda = new List<Moneda>();
            List<Auto> ObjAuto = new List<Auto>();


            Menu(ObjAuto, ObjMoneda);
        }

        static void Menu (List<Auto> ObjAuto, List<Moneda> ObjMoneda)
        {
           
            int opcion= 0;
            string msj = "\n 1. Ingrese MONEDA \n 2. Ingrese AUTO  \n 3. Informar ganancias total de la empresa  \n 4. Listar Monedas ingresadas \n 5. Listar Autos ingresados \n 6. Salir ";
           
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"\n {msj} \n");
                opcion = int.Parse(Console.ReadLine());
                
                
                switch (opcion)
                {

                    case 1 :

                        Console.ForegroundColor = ConsoleColor.Gray;
                        AgregarMoneda(ObjMoneda);

                        break;

                    case 2 :


                        AgregarAuto(ObjAuto, ObjMoneda);
                   
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\n Ganacias de la empresa del total de los autos: $ {Moneda.Ganancias_final} pesos. \n Stock de automoviles: {Auto.Stock_auto} automoviles \n ");

                        break;

                    case 4:

                        Console.ForegroundColor = ConsoleColor.Blue; ;
                        ListarMoneda(ObjMoneda);

                        break;

                    case 5:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        ListarAutos(ObjAuto);

                        break;

                    case 6:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n FIN DEL PROGRAMA");
                        break;

                    default:

                        Console.WriteLine("\n Opción invalida, re ingrese opción, muchas gracias ");
                        break;

                }


            }while (opcion != 6);

        }

        static void AgregarAuto (List<Auto> ObjAuto, List<Moneda> ObjMoned)
        {
            char sigue = 'S';
            int cont = 0;

          while (sigue.ToString().ToUpper().Equals("S"))
            {
                ObjAuto.Add(new Auto());

                AgregarValorAuto(ObjAuto, ObjMoned, cont);
               
                cont++;
                Console.WriteLine("\n Ingrese S para continuar con la carga de MONEDAS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
                
            }

               
        }

        static void AgregarMoneda (List <Moneda> ObjMoneda)
        {
            char sigue = 'S';
            
            while (sigue.ToString().ToUpper().Equals("S"))
            {
                ObjMoneda.Add(new Moneda(ObjMoneda.Count)); // Agrego moneda
             
                Console.WriteLine("\n Ingrese S para continuar con la carga de MONEDAS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }

        }

        static void AgregarValorAuto (List<Auto> ObjAuto, List<Moneda> ObjMoned, int cont )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ListarMoneda(ObjMoned);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Seleccione ID MONEDA COTIZADA del valor del auto, DOLAR EURO, PESO, ETC. Si la moneda no esta en la lista ingrese 99 y debera cargar en sistema : ");
            int opcionmoneda = int.Parse(Console.ReadLine());

            if (opcionmoneda != 99)
            {
               
                Console.Write("\n Ingrese valor de la moneda en referencia a pesos al día de hoy: "); // Puse esto porque el querido peso argentino sufre modificaciones todo el tiempo
                ObjMoned[opcionmoneda].Cotizacion = double.Parse(Console.ReadLine());


                Console.Write("\n Ingrese valor inicial del auto: ");
                ObjMoned[opcionmoneda].Valor_auto = double.Parse(Console.ReadLine());



                double valor_Auto = ObjMoned[opcionmoneda].Valor_auto * ObjMoned[opcionmoneda].Cotizacion;

                ObjAuto[cont].Costo = valor_Auto; // valor inicial del auto 

                Console.WriteLine("\n Ingrese valor de venta al publico ");
                ObjMoned[opcionmoneda].Precio_venta = double.Parse(Console.ReadLine());

                double preciopublico = ObjMoned[opcionmoneda].Precio_venta * ObjMoned[opcionmoneda].Cotizacion;

                //  ganancias del auto 

                double ganancias = ObjMoned[opcionmoneda].Ganancias(preciopublico, valor_Auto); // saco ganancias del auto 

                preciopublico = ObjMoned[opcionmoneda].Precio_venta;

                ObjAuto[cont].Venta_publico = preciopublico;  // venta al publico 

                ObjAuto[cont].Ganancias = ganancias; // saco ganancias del auto es la gancia del auto ingresado 
            }
           else
            {
                Console.WriteLine("La moneda perteneciente al automovil no se encuentra cargada ");
            }
        }
       
        static void ListarMoneda (List<Moneda> ObjMoneda)
        {
            if (ObjMoneda.Count > 0)
            {
                foreach (Moneda monedas in ObjMoneda)
                {
                    Console.WriteLine(monedas.ToString());
                }
            }
            else
            {
                Console.WriteLine("No ingreso ningun tipo de monedas");
            }
        }

        static void ListarAutos (List<Auto> ObjAuto)
        {
            if (ObjAuto.Count > 0)
            {
                foreach (Auto autos in ObjAuto)
                {
                    Console.WriteLine(autos.ToString());
                }
            }
            else
            {
                Console.WriteLine("No ingreso ningun tipo de monedas");
            }
        }
    }
}
