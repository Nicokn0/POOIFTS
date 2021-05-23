using System;
using System.Collections.Generic;

namespace Ej_15__Herencia_Computadora_
{
    class Ejecutora
    {
        /*Tomando como base el diagrama de clase anterior se pide crear un programa que permita crear objetos del tipo 
       PcEscritorio, Notebook, SmartPhone y PcAllInOne. Cada clase deberá ser responsable de administrar la carga de 
       los datos en el constructor default. Agregar al diagrama de clase un método ToString para que cada una pueda 
       devolver la información correspondiente a su tipo.
       a) El programa debe contar con métodos para poder: 
       a. cargar cada uno de los objetos
       b. listar todos los objetos creados visualizando todo los atributos 
       c. eliminar un objeto en particular (se debe poder seleccionar un objeto y sacarlo de la colección)
       b) Debe informar la cantidad de computadoras creadas estén o no dentro de la colección. */

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
                string msj1 = ("\n 1. Cargar objetos \n 2. Listar todos los objetos creados \n 3. Eliminar un objeto en particular \n 4. Informar cantidad de computadoras creadas \n Salir");

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

                        EliminarElementos(Objcompu);

                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine($"CANTIDAD DE DISPOSITIVOS CREADOS: {Computadora.Cont_elementos_electronicos}");
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
            char sigue = 'S';


            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("\n Ingrese dispositivo a cargar: 1. PC Escritorio \t 2. Pac All IN ONE \t 3. Notebook \t 4. Smartphone");
                int opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                if (opcion == 1)
                {
                    Console.WriteLine("¿Quiere sumar dicho dispositivo a la lista? Marque 1. Si, 2. NO");
                    int pregunta = int.Parse(Console.ReadLine());

                    if (pregunta == 1)
                    {
                        Objcompu.Add(new PcEscritorio());
                    }
                    else
                    {

                        PcEscritorio objpc = new PcEscritorio();
                    }




                }
                else
                {
                    if (opcion == 2)
                    {
                        Console.WriteLine("¿Quiere sumar dicho dispositivo a la lista? Marque 1. Si, 2. NO");
                        int pregunta = int.Parse(Console.ReadLine());

                        if (pregunta == 1)
                        {
                            Objcompu.Add(new PacAllInOne());
                        }
                        else
                        {

                            PacAllInOne objPcall = new PacAllInOne();
                        }

                    }
                    else
                    {
                        if (opcion == 3)
                        {
                            Console.WriteLine("¿Quiere sumar dicho dispositivo a la lista? Marque 1. Si, 2. NO");
                            int pregunta = int.Parse(Console.ReadLine());

                            if (pregunta == 1)
                            {
                                Objcompu.Add(new Notebook());
                            }
                            else
                            {
                                Notebook objnote = new Notebook();
                            }

                        }
                        else
                        {
                            if (opcion == 4)
                            {
                                Console.WriteLine("¿Quiere sumar dicho dispositivo a la lista? Marque 1. Si, 2. NO");
                                int pregunta = int.Parse(Console.ReadLine());

                                if (pregunta == 1)
                                {
                                    Objcompu.Add(new Smartphone());
                                }
                                else
                                {
                                    Smartphone objcelu = new Smartphone();
                                }


                            }
                        }
                    }
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

        static void EliminarElementos(List<Computadora> Objcomp)
        {
            int dispo_a_eliminar = 0;

            if (Objcomp.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Seleccione el DISPOSITIVO a eliminar \n");

                    ListarObjetos(Objcomp);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del DISPOSITIVO a eliminar:  ");
                    dispo_a_eliminar = int.Parse(Console.ReadLine());

                    dispo_a_eliminar--;

                } while (dispo_a_eliminar < 0 || dispo_a_eliminar > Objcomp.Count);

                Objcomp.RemoveAt(dispo_a_eliminar);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Se elimino el DISPOSITIVO correctamente \n");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }
        }
    }
}
