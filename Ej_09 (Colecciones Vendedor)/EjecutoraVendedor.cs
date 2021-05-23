using System;
using System.Collections.Generic;

namespace Ej_09__Colecciones_Vendedor_
{
    class EjecutoraVendedor
    {
        /*
           En un comercio se conoce su nombre, su número de CUIT y todos los vendedores que trabajan en el mismo
        De cada vendedor se conoce: Nombre, número de DNI, el importe total de ventas que realizo el primer semestre del año y
        el importe del segundo semestre. Se pide hacer  un programa definiendo las clases  necesarias para:

        a) Agregar  un vendedor con importe de ventas de ambos semestres 
        b) Eliminar un vendedor dado su número de DNI 
        c) Informar el total de las ventas realizadas en el año por el comercio.
        d) Dado un número de DNI, informar que semestre el importe de ventas fue mayor. 
        
         
         
         */
        static void Main(string[] args)
        {
            int opcion = 0;
            Comercio objcomercio = new Comercio();
            List<Vendedor> l_vendedor = new List<Vendedor>();



            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("INGRESE NOMBRE DE LA EMPRESA:");
            objcomercio.Nombre_comercio(Console.ReadLine());
            Console.Write("INGRESE CUIL:");
            objcomercio.Numero_cuil(int.Parse(Console.ReadLine()));

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        AgregarVendedor(l_vendedor);


                        break;

                    case 2:

                        EliminarVendedor(l_vendedor);

                        break;

                    case 3:

                        InformeVentaTotal(objcomercio);

                        break;

                    case 4:

                        SemestreMayorVenta(l_vendedor);
                        break;



                    case 5:

                        Console.WriteLine("FIN DEL PROGRAMA");
                        break;
                }


            } while (opcion != 5);
        }

        static void Menu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            string mensaje = ("\n 1. Agregar vendedor. \n 2. Eliminar vendedor por DNI \n 3. Informar el total de las ventas del COMERCIO \n 4. Dado un DNI, informar semestre con mas ventas. \n 5. Finalizar ");

            Console.WriteLine(mensaje);


        }

        static void AgregarVendedor(List<Vendedor> obj_vendedor)
        {
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\t Ingrese información del vendedor \n");
                obj_vendedor.Add(new Vendedor());

                Console.WriteLine("Ingrese S para continuar con la carga de VENDEORES. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void EliminarVendedor(List<Vendedor> objvendedor)
        {


            if (objvendedor.Count > 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                int posicion_encontrar = Busqueda(objvendedor);

                if (posicion_encontrar == -1)
                {
                    Console.WriteLine("NO se encontro dicho DNI");
                }
                else
                {
                    Console.WriteLine("\n");

                    objvendedor.RemoveAt(posicion_encontrar);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Se elimino el DNI correctamente \n");
                }




            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }


        }


        static void InformeVentaTotal(Comercio objcomercio)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($" La venta TOTAL de {objcomercio.Nombre_comercio()} es: $ {Vendedor.Acu_ventas_comercio}\n");
        }

        static void SemestreMayorVenta(List<Vendedor> objvendedor)
        {


            if (objvendedor.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;


                ListaVendedor(objvendedor);
                Console.WriteLine("\n");

                int posicion_encontrar = Busqueda(objvendedor);

                if (posicion_encontrar == -1)
                {
                    Console.WriteLine("NO se encontro dicho DNI");
                }
                else
                {
                    Console.Write($"{objvendedor[posicion_encontrar].ToString()} ");
                }

                Console.WriteLine("\n");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }
        }

        static void ListaVendedor(List<Vendedor> objvendedor)
        {

            if (objvendedor.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n EN LISTA HAY  --- {objvendedor.Count} --- VENDEDORES \n");

                int i = 1;

                foreach (Vendedor vend in objvendedor)
                {
                    Console.WriteLine($"N°: {i++}. \t {vend.ToString()}");

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }



        }


        static int Busqueda(List<Vendedor> objvendedor)
        {


            int posicionencontrada = -1;
            int posicionactual = 0;
            int cantelementos = objvendedor.Count;


            Console.Write("Seleccione el DNI a consultar. ");
            int doc_buscar = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            do
            {

                if (objvendedor[posicionactual].Numero_dni == doc_buscar)
                {
                    posicionencontrada = posicionactual;
                }
                else
                {
                    posicionactual++;
                }

            }

            while (posicionencontrada == -1 && posicionactual < cantelementos);

            return posicionencontrada;

        }
    }
}

