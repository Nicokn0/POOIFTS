using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_13__Colecciones_Productos_
{
    class Producto
    {
        private string descripcion;
        private string codigo;
        private int puntoDePedido;
        private int maximoStockPermitido;
        private int stockProducto;
        private double precioUnitario;


        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int PuntoDePedido1 { get => puntoDePedido; set => puntoDePedido = value; }
        public int MaximoStockPermitido1 { get => maximoStockPermitido; set => maximoStockPermitido = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }

        public Producto()
        {

            IngresoDatos();
        }

        public double PrecioUnitario()
        {
            return this.precioUnitario;
        }

        public void PrecioUnitario(double cant)
        {
            precioUnitario = cant;
        }

        public void Vender(int cantidad)
        {
            string mensaje = "";

            if (this.stockProducto >= cantidad)
            {
                this.stockProducto = this.stockProducto - cantidad;
                mensaje = "\n Se ha vendido el producto " + this.descripcion;

                if (this.stockProducto <= this.puntoDePedido)
                {
                    mensaje = mensaje + $"\n Debe realizar una nueva compra. El stock de {this.descripcion} es {this.stockProducto} está por debajo de punto de pedido {this.puntoDePedido}";
                }
            }
            else
            {
                mensaje = $"\nSolamente hay {this.stockProducto} unidades de {this.descripcion}, es insuficiente para la venta. ";
            }
            Console.WriteLine(mensaje);
        }

        public void Comprar(int cantidad)
        {
            string mensaje = "";

            if (this.maximoStockPermitido >= cantidad + this.stockProducto)
            {
                this.stockProducto = this.stockProducto + cantidad;
                mensaje = "\n Se ha comprado el producto " + this.descripcion;

                if (this.stockProducto <= this.puntoDePedido)
                {
                    mensaje = mensaje + $"\nDebe realizar una nueva compra. El stock de {this.descripcion} es {this.stockProducto} está por debajo de punto de pedido {this.puntoDePedido}";
                }
            }
            else
            {
                mensaje = $"\nLa cantidad a comprar supera el stock maximo permitido puesto que el stock actual es {this.stockProducto} y la cantidad maxima admitda es :{this.maximoStockPermitido}";
            }
            Console.WriteLine(mensaje);
        }

        public void ConsultarStock()
        {
            Console.WriteLine($"\nEl stock del producto  --- {this.codigo} -- {this.descripcion} -- es: {this.stockProducto}----------- ");
        }

        public void PuntoDePedido(int cantidad)
        {
            string mensaje;
            if (cantidad >= 0 && cantidad <= this.maximoStockPermitido)
            {
                this.puntoDePedido = cantidad;
                mensaje = "Se ha cambiado el punto de pedido";
            }
            else
            {
                mensaje = "No se pudo cambiar el punto de pedido";
            }
            Console.Write(mensaje);
        }

        public void MaximoStockPermitido(int cantidad)
        {
            string mensaje;
            if (cantidad >= 0 && cantidad > this.puntoDePedido)
            {
                this.maximoStockPermitido = cantidad;
                mensaje = "Se ha cambiado el stock máximo permitido\n";
            }
            else
            {
                mensaje = "No se pudo cambiar el stock máximo permitido\n";
            }
            Console.Write(mensaje);
        }

        public void IngresoDatos()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nIngrese el código de producto: "); this.codigo = Console.ReadLine();

            Console.Write("\nIngrese la descripción del producto: "); this.descripcion = Console.ReadLine();

            Console.Write("\nIngrese el punto de pedido del producto: "); this.puntoDePedido = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese el máximo stock permitido del producto: "); MaximoStockPermitido(int.Parse(Console.ReadLine()));

            Console.Write($"\nIngrese el valor del producto {this.descripcion}: $ "); this.precioUnitario = double.Parse(Console.ReadLine());
            this.stockProducto = 0;
        }



        public override string ToString()
        {

            return ($"\n El stock del producto {this.descripcion} -- es de : {this.stockProducto} --- Código: {this.codigo}. Valor unitario: $ {this.precioUnitario}. Valor del stock: $ {(this.stockProducto * this.precioUnitario)} ");
        }

    }
}

