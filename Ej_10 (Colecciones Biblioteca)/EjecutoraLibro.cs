using System;
using System.Collections.Generic;

namespace Ej_10__Colecciones_Biblioteca_
{
    class EjecutoraLibro
    {
        static void Main(string[] args)
        {

            /*
             Diseñe e implemente las clases necesarias para trabajar con los libros de una biblioteca. Para ello, defina los atributos que considere
            necesarios para crear cada libro tomando en cuenta la responsabildades descriptas a continuación.

            * Consulta existencia del libro. Obtener Libro () Devuelve un libro.
            * Agregar ejemplares  a la biblioteca, agregarLibros()
            * Tomar prestado un libro  de biblioteca SolicitarLibro ().
            * Devolver un libro que fue prestado por la biblioteca, DevolverLibro ().
            
             */

            List<Libro> objlibro = new List<Libro>();

            int opcion = 0;

            string menu = "\n Menu. \n 1. Consultar existencia del libro \n 2. Agregar ejemplares a la biblioteca \n 3. Tomar prestado un libro \n 4. Devolver libro \n 5. Listar libros Biblioteca \n 6.FIN PROGRAMA  ";

            do
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(menu);
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        ConsultarLibro(objlibro);

                        break;

                    case 2:

                        AgregarEjemplares(objlibro);

                        break;

                    case 3:

                        SolicitarLibro(objlibro);

                        break;

                    case 4:
                        DevolucionLibro(objlibro);
                        break;

                    case 5:

                        ListarLibros(objlibro);

                        break;
                    case 6:

                        Console.WriteLine("FIN DEL PROGRAMA");

                        break;
                }


            }
            while (opcion != 6);
        }

        static void ConsultarLibro(List<Libro> objLibro)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if (objLibro.Count > 0)
            {
                int posicion_encontrar = Busqueda(objLibro);

                if (posicion_encontrar == -1)
                {
                    Console.WriteLine(" No se encontro el libro a buscar \n");
                }
                else
                {

                    Console.WriteLine($"\n El libro ingresado se encuentra en la biblioteca.\n");
                    Console.Write($"{objLibro[posicion_encontrar].ToString()} ");
                }

                Console.WriteLine("\n");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n ---- No hay ningun libro en la biblioteca---- \n");
            }
        }

        static void AgregarEjemplares(List<Libro> objLibro)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\t Ingrese información del libro a cargar en la biblioteca \n");
                objLibro.Add(new Libro());

                Console.WriteLine("\n Ingrese S para continuar con la carga de libros a la biblioteca. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void SolicitarLibro(List<Libro> objLibro)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int posicion_encontrar = Busqueda(objLibro);

            if (posicion_encontrar == -1)
            {
                Console.WriteLine("NO se encontro el libro a buscar");
            }
            else
            {
                if (objLibro[posicion_encontrar].Pedir_libro == false)
                {
                    // VER COMO PONER QUE EL LIBRO SE ENCONTRO
                    Console.WriteLine($"El libro ingresado se encuentra en la biblioteca para prestar.\n");


                    Console.Write("\n Indique escribiendo SI o NO si quiere prestar el libro: ");
                    if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        objLibro[posicion_encontrar].Pedir_libro = true;
                        objLibro[posicion_encontrar].Devolucion_libro = true;


                        Console.WriteLine($"\n El libro: {objLibro[posicion_encontrar].Nombre_libro}, acaba de ser prestado");

                    }
                    else
                    {
                        Console.WriteLine("El libro no puede ser prestado");
                    }
                }
                else
                {
                    Console.WriteLine("EL LIBRO NO SE PUEDE PRESTAR YA QUE FUE PRESTADO CON ANTERIORIDAD Y NO FUE DEVUELTO");
                }


            }

            Console.WriteLine("\n");
        }

        static void DevolucionLibro(List<Libro> objLibro)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            int posicion_encontrar = Busqueda(objLibro);

            if (posicion_encontrar == -1)
            {
                Console.WriteLine("NO se encontro el libro a buscar");
            }
            else
            {

                if (objLibro[posicion_encontrar].Devolucion_libro)
                {
                    Console.WriteLine($"El libro -- {objLibro[posicion_encontrar].Nombre_libro} --  Se encuentra en la biblioteca y fue prestado.");

                    Console.Write("\n Indique escribiendo SI o NO si quiere devolver el libro: ");

                    if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (objLibro[posicion_encontrar].Pedir_libro)
                        {
                            objLibro[posicion_encontrar].Pedir_libro = false;
                            objLibro[posicion_encontrar].Devolucion_libro = false;

                            Console.WriteLine($"El libro: {objLibro[posicion_encontrar].Nombre_libro}. se entrego correctamente");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No se devolvio el libro");
                    }

                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("EL libro no fue prestado, se encuentra en la biblioteca DISPONIBLE");
                }
            }

            Console.WriteLine("\n");
        }

        static int Busqueda(List<Libro> objLibro)
        {


            int posicionencontrada = -1;
            int posicionactual = 0;
            int cantelementos = objLibro.Count;


            Console.Write("\n Indique  el código del  Libro a consultar. \n");
            int cod_libro = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            do
            {

                if (objLibro[posicionactual].Codigo_libro == cod_libro)
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

        static void ListarLibros(List<Libro> objlibro)
        {
            if (objlibro.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n EN LA BIBLIOTECA HAY   --- {objlibro.Count} --- LIBROS \n");

                int i = 1;

                foreach (Libro libro in objlibro)
                {
                    Console.WriteLine($"\n N°: {i++}. \n {libro.ToString()}");

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }
        }
    }
}
    

