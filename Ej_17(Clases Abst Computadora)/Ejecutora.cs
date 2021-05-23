using System;
using System.Collections.Generic;

namespace Ej_17_Clases_Abst_Computadora_
{
    /* 

      . De acuerdo al siguiente diagrama de clase se pide crear un programa que permita al usuario seleccionar crear un 
tipo de computadora particular, las opciones serán PcEscritorio, Notebook, SmartPhone y PcAllInOne.

         Cada una de las clases será responsable de agregar un método ToString() que aporte información sobre todos 
    los atributos descriptos en el diagrama de clase. Deberás seleccionarse la mejor estrategia posible para no 
    repetir código ni información.
    Las opciones que tendrá el usuario desde la aplicación será:
    a. Agregar un tipo de computadora
    a.1 Agregar una PcEscritorio al stock de computadoras
    a.2 Agregar una Notebook al stock de computadoras
    a.3 Agregar una PcAllInOne al stock de computadoras
    a.4 Agregar un SmartPhone al stock de computadoras

    b. Informar la cantidad de computadoras agregadas al stock

    b.1 Informar la cantidad de PcEscritorio agregadas al stock de computadoras
    b.2 Informar la cantidad de Notebook agregadas al stock de computadoras
    b.3 Informar la cantidad de PcAllI9nOne agregadas al stock de computadoras
    b.4 Informar la cantidad de SmartPhone agregadas al stock de computadoras
    b.5 Informar la cantidad total de computadas
    c. Visualizar los datos de todos los objetos creados, utilizando el método ToString()

    El punto clave de este ejercicio es que sólo se podrá crear una sola colección de objetos, se deja a criterio del alumno 
    como cumplir este desafío.


     */
    class Ejecutora
    {
        static void Main(string[] args)
        {

            List<Computadora> Objctecno = new List<Computadora>();
            Menu(Objctecno);
        }

        static void Menu(List<Computadora> Objcompu)
        {

            int opcion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                string msj1 = ("\n 1. Cargar diferentes  DISPOSITIVOS \n 2. Listar todos los objetos creados \n 3. MENU STOCK por Dispositivo en particular \n 4. Stock TOTAL de DISPOSITIVOS INGRESADOS AL SISTEMA \n 5. Salir");

                Console.WriteLine($"\n Stock de dispositivos hata el momento: {Objcompu.Count} unidades ");
                Console.WriteLine(msj1);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        AgregarObjeto(Objcompu);

                        break;

                    case 2:

                        ListarObjetos(Objcompu);

                        break;
                    case 3:

                        StockDispositivos(Objcompu);

                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine($"CANTIDAD DE DISPOSITIVOS CREADOS: {Objcompu.Count}");
                        break;

                    case 5:

                        Console.WriteLine("FIN DEL PROGRAMA");

                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta, vuelva a ingresar opción");
                        break;
                }

            } while (opcion != 5);

        }

        static void AgregarObjeto(List<Computadora> Objcompu)
        {
            char sigue = 'S'; int opcion;



            Console.ForegroundColor = ConsoleColor.DarkGreen;


            while (sigue.ToString().ToUpper().Equals("S"))
            {

                Console.WriteLine("\n Ingrese dispositivo a cargar: 1. PC Escritorio \t 2. Pac All IN ONE \t 3. Notebook \t 4. Smartphone \n 5. Salir");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                switch (opcion)
                {
                    case 1:

                        Objcompu.Add(new PcEscritorio());

                        break;

                    case 2:


                        Objcompu.Add(new PacAllinOne());

                        break;

                    case 3:

                        Objcompu.Add(new Notebook());

                        break;

                    case 4:

                        Objcompu.Add(new SmartPhone());
                        break;

                    case 5:

                        Console.WriteLine("SALIR");


                        break;

                    default:

                        Console.WriteLine("OPCIÓN INCORRECTA");

                        break;
                }

                Console.WriteLine("\n Ingrese S para continuar con la carga de DISPOSITIVOS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }


        }


        static void ListarObjetos(List<Computadora> Objcompu)
        {
            if (Objcompu.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n EN LISTA HAY  --- {Objcompu.Count} --- DISPOSITIVOS \n");

                int i = 1;

                foreach (Computadora vend in Objcompu)
                {
                    Console.WriteLine($"N°: {i++}. \t {vend.ToString()} \n");

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }

        }

        static void StockDispositivos(List<Computadora> Objcompu)
        {

            string menu = ("\n 1. Stock PC ESCRITORIO \n 2. Stock NOTEBOOK  \n 3. Stock SmarthPhone \n 4. Stock PackAllInOne \n 5. SALIR");
            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(menu);
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        // d que clase obj estoy buscando pertenece
                        Console.ForegroundColor = ConsoleColor.Green;
                        int resu;
                        resu = PcEscritorio.Cont_PcEscritorio - PacAllinOne.Cont_PacAll;

                        if (resu == 0 && PcEscritorio.Cont_PcEscritorio == 1)
                        {
                            Console.WriteLine("1");
                        }
                        else
                        {
                            if (PcEscritorio.Cont_PcEscritorio == 0)
                            {
                                Console.WriteLine("0");
                            }
                            else
                            {
                                Console.WriteLine(resu);

                            }

                        }

                        Console.WriteLine($"\n LA CANTIDAD DE PC ESCRITORIO INGRESADAS AL SISTEMA SON : { resu} UNIDADES");

                        break;

                    case 2:

                        Console.WriteLine($"LA CANTIDAD DE NOTEBOOK INGRESADAS AL SISTEMA SON : {Notebook.Cont_Notebook} UNIDADES");
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;

                    case 3:

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"LA CANTIDAD DE SMARTH PHONE INGRESADAS AL SISTEMA SON : {SmartPhone.Cont_Smarth} UNIDADES");


                        break;

                    case 4:

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"LA CANTIDAD DE PAC ALL IN ONE  INGRESADAS AL SISTEMA SON : {PacAllinOne.Cont_PacAll} UNIDADES");


                        break;



                    case 5:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n FIN DE MENU DE STOCK DE DISPOSITIVOS \n");

                        break;

                    default:

                        Console.WriteLine("Opcion incorrecta, vuelva a ingresar opción");
                        break;
                }
            } while (opcion != 5);
        }
    }

}
