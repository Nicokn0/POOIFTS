using System;
using System.Collections.Generic;

namespace Ej_13__Colecciones_Productos_
{
    class EjecutoraProducto
    {
        /* 
             La clase producto deberá controlar que no se venda más productos que la cantidad disponible en stock, en ese caso deberá informar que no se puede realizar la venta. 
        La clase producto deberá informar cuando se esté por debajo del límite del punto de pedido. 
        La clase producto deberá controlar que la compra no supere el stock máximo de producto permitido. 
        La clase producto deberá informar el stock de producto valorizado. 
        Crear la clase ejecutora que soporte la administración de a lo sumo Productos. El menú de la clase ejecutora estará 

        compuesta por: 
        •	1.Crear Producto 
        •	2 Comprar producto 
        •	3 Vender Producto 
        •	4 Consultar Saldo (debe informar cantidad, valor unitario y total) 
        •	5 Cambiar punto de pedido 
        •	6 Cambiar stock Máximo permitido 
        •	7 Cambiar precio Unitario.
        •	0 Salir 

        Un producto se puede crear de dos formas 
        a)	Indicando el código de producto y descripción y luego completando los datos a posteriori 
        b)	Completando todos los datos requeridos por los atributos al crear el producto. 

        Pensar que controles tiene que hacer la clase para poder operar cuando se use la primer forma . (valores predeterminados, etc.)


         3. Siguiendo la pauta del ejemplo resuelto adaptar el ejercicio 6 de la unidad 2 para poder almacenar el tipo de 
         objeto en una colección permitiendo agregar, eliminar y listar todos los objetos de la colección.

         Adaptado:

           compuesta por: 
        •	1.Crear Producto 
        •    2. Listar Producto (Consulta de saldos)
        •	3 Comprar producto 
        •	4 Consultar stock maximo permitido Vender  
        •	5. Vender 
        •    6. Cambiar punto de pedido
        •	6 Cambiar stock Máximo permitido 
        •	7 Cambiar precio Unitario.
             8.Eliminar
        •	0 Salir 

     */


        static void Main(string[] args)
        {
            List<Producto> objproducto = new List<Producto>();

            int opcion;
            string menu = "\n Menu:\n 1 Crear producto\n 2 Listar Productos (Consulta de ) \n 3 Comprar\n 4 Consultar Stock maximo permitido \n 5 Vender  \n 6 Modificar punto de pedido \n 7 Modificar stock Maximo \n 8 Modificar precio unitario\n 9. Eliminar producto \n 10 Salir";

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{menu}\n");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        AgregarProd(objproducto);


                        break;

                    case 2:

                        ListarProdu(objproducto);

                        break;


                    case 3:

                        Console.WriteLine("\n");

                        ComprarProdu(objproducto);
                        break;

                    case 4:

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        ConsultarStock(objproducto);

                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        VenderProdu(objproducto);

                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        PuntoPedido(objproducto);
                        break;

                    case 7:

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        ModificarStock(objproducto);
                        break;

                    case 8:

                        Console.ForegroundColor = ConsoleColor.Green;
                        ModificarPrecio(objproducto);
                        break;

                    case 9:

                        Console.ForegroundColor = ConsoleColor.Red;

                        EliminarProducto(objproducto);

                        break;
                    case 10:
                        Console.WriteLine("FIN DEL PROGRAMA");
                        break;
                }

            } while (opcion != 10);
        }

        static void AgregarProd(List<Producto> objprodu)
        {
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.WriteLine("\t Ingrese información del PRODUCTO ");
                objprodu.Add(new Producto());

                Console.WriteLine("\n Ingrese S para continuar con la carga de los productos. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void ListarProdu(List<Producto> objprod)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n EN LISTA HAY  --- {objprod.Count} --- PRODUCTOS \n");
            int i = 1;
            foreach (Producto objPer in objprod)
            {

                Console.Write($"\n N°: {i++}  {objPer.ToString()}");


            }
        }

        static void ComprarProdu(List<Producto> objprodu)
        {

            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO a COMPRAR:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ingrese la cantidad a comprar. \n");
                int comprar = int.Parse(Console.ReadLine());

                objprodu[seleccion_produ].Comprar(comprar);


            }
        }

        static void ConsultarStock(List<Producto> objprodu)
        {

            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO A CONSULTAR STOCK:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("STOCK A CONSULTAR. \n");

                objprodu[seleccion_produ].ConsultarStock();


            }
        }

        static void VenderProdu(List<Producto> objprodu)
        {
            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO A VENDER:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n INGRESE LA CANTIDAD A VENDER \n");
                int cant_vender = int.Parse(Console.ReadLine());


                objprodu[seleccion_produ].Vender(cant_vender);


            }
        }

        static void PuntoPedido(List<Producto> objprodu)
        {

            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO A modificar PUNTO DE PEDIDO:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("Ingrese el nuevo punto de pedido - ORDENAR NUEVA COMPRA A PROVEEDORES: ");
                int cant = int.Parse(Console.ReadLine());


                objprodu[seleccion_produ].PuntoDePedido(cant);


            }
        }

        static void ModificarStock(List<Producto> objprodu)
        {
            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO A modificar STOCK:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("Ingrese el nuevo STOCK: ");
                int cant = int.Parse(Console.ReadLine());


                objprodu[seleccion_produ].MaximoStockPermitido(cant);
            }
        }

        static void ModificarPrecio(List<Producto> objprodu)
        {
            int seleccion_produ = 0;

            if (objprodu.Count > 0)
            {

                do
                {

                    ListarProdu(objprodu);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número de la lista del PRODUCTO A modificar PRECIO UNITARIO:  ");
                    seleccion_produ = int.Parse(Console.ReadLine());

                    seleccion_produ--;

                } while (seleccion_produ < 0 || seleccion_produ > objprodu.Count);

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("Ingrese el nuevo PRECIO UNITARIO: $ ");
                double cant = int.Parse(Console.ReadLine());


                objprodu[seleccion_produ].PrecioUnitario(cant);
            }
        }

        static void EliminarProducto(List<Producto> objprodu)
        {

            int pos = 0;
            string sele_rect = "";

            if (objprodu.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                ListarProdu(objprodu);
                Console.WriteLine("\n");

                Console.WriteLine("\n Ingrese el código del producto que desea buscar: ");
                sele_rect = Console.ReadLine();

                if (sele_rect.Contains(objprodu[pos].Codigo))
                {
                    Console.WriteLine($"\n El producto esta en la posicion: {pos}");

                    objprodu.RemoveAt(pos);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Se elimino el PRODUCTO  correctamente \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n No se encontro el producto a ELIMINAR. ");
                }



            }


        }
    }
}
