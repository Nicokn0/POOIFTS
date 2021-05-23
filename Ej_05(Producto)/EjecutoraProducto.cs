using System;

namespace Ej_05_Producto_
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



   */

    class EjecutoraProducto
    {
        static void Main(string[] args)
        {
            int opcion, cantidad;
            string menu = "\n  Menu:\n 1 Crear producto\n 2 Comprar\n 3 Vender \n 4 Consultar Saldo \n 5 Modificar punto de pedido \n 6 Modificar stock Maximo \n 7 Modificar precio unitario\n 0 Salir";

            Producto ProductoA = null;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{menu}\n");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        if (ProductoA == null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Oprima 1 para crear el producto con datos mínimos ---  2 para completar todos los datos");
                            if (Console.ReadLine().Equals("2"))
                            {
                                ProductoA = new Producto();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Ingrese el código y descripción del producto");
                                ProductoA = new Producto(Console.ReadLine(), Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto ya está creado!");
                        }
                        break;

                    case 2:
                        if (ProductoA != null)
                        {
                            Console.WriteLine("Ingrese la cantidad a comprar");
                            cantidad = int.Parse(Console.ReadLine());
                            ProductoA.Comprar(cantidad);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }
                        break;

                    case 3:
                        if (ProductoA != null)
                        {

                            Console.WriteLine("Ingrese la cantidad a vender");
                            cantidad = int.Parse(Console.ReadLine());
                            ProductoA.Vender(cantidad);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 4:
                        if (ProductoA != null)
                        {
                            ProductoA.ConsultarStock();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }

                        break;

                    case 5:

                        if (ProductoA != null)
                        {
                            Console.WriteLine("Ingrese el nuevo punto de pedido - ORDENAR NUEVA COMPRA A PROVEEDORES");
                            cantidad = int.Parse(Console.ReadLine());
                            ProductoA.PuntoDePedido(cantidad);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }
                        break;

                    case 6:
                        if (ProductoA != null)
                        {
                            Console.WriteLine("Ingrese el nuevo stock máximo permitido");
                            cantidad = int.Parse(Console.ReadLine());
                            ProductoA.MaximoStockPermitido(cantidad);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }
                        break;


                    case 7:
                        if (ProductoA != null)
                        {
                            Console.WriteLine("\n Ingrese el nuevo valor unitario del producto");
                            ProductoA.PrecioUnitario = float.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("El producto no está creado");
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opción ingresada no es correctan\n");
                        break;
                }

            } while (opcion != 0);

            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);

        }
    }
    
}
