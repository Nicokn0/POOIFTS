using System;
using System.Collections.Generic;

namespace Ej_07__Colecciones_Triangulo_
{
    class EjecutoraTriangulo
    {
        /* Se pide crear un programa que permita manipular una cantidad no determinada de triángulos, adicionalmente a los métodos perímetro y superficie se deberá programar un método ToString() que devolverá un tipo de dato string con la composición de los valores de la instancia del triangulo (el número de triangulo, sus tres lados y el valor de la altura)
          Para esto se pide un programa ejecutora que deberá tener un menú que tenga las siguientes opciones:
         1.Agregar Triángulo
         2. Eliminar un Triángulo (Elimina el último cargado)
         3. Listar Todos. (Lista todos los triángulos cargados en la colección)
         4. Terminar Programa
         Cada opción deberá ser programada en un método específico a excepción de Terminar Programa.
         */

        static void Main(string[] args)
        {
            List<Triangulo> objTriangulo = new List<Triangulo>();
            int opcion = 0;

            do
            {
                Menu();
                Console.WriteLine("\n");
                opcion = int.Parse(Console.ReadLine());

                Menuopciones(opcion, objTriangulo);


            }
            while (opcion != 4);
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string menu = ("\n -1- Agregar Triangulo \n -2- Eliminar Triangulo (Eliminar el ultimo cargado) \n -3- Listar todos \n -4- Terminar programa \n");

            Console.WriteLine(menu);

        }

        public static void Menuopciones(int opcion, List<Triangulo> objTriangulo)
        {


            switch (opcion)
            {
                case 1:

                    AgregarTriangulo(objTriangulo);

                    break;


                case 2:


                    BorrarUltimoElemento(objTriangulo);

                    break;

                case 3:


                    CrearTriangulos(objTriangulo);

                    break;

                case 4:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FIN DEL PROGRAMA");

                    break;

                default:

                    Console.WriteLine("OPCION INCORRECTA, RE INGRESE OPCION CORRECTA");
                    break;
            }


            static void AgregarTriangulo(List<Triangulo> objTriangulo)
            {
                char sigue = 'S';

                while (sigue.ToString().ToUpper().Equals("S"))
                {
                    Console.WriteLine("\t Ingrese información del TRIANGULO \n");
                    objTriangulo.Add(new Triangulo());

                    Console.WriteLine("Ingrese S para continuar con la carga de los TRIANGULOS. Cualquier otra tecla para finalizar");
                    sigue = char.Parse(Console.ReadLine());
                }
            }

            static void BorrarUltimoElemento(List<Triangulo> objTriangulo)
            {
                if (objTriangulo.Count > 0)
                {
                    objTriangulo.RemoveAt(objTriangulo.Count - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("SE HA ELIMINADO EL ULTIMO TRIANGULO");
                }
                else
                {
                    Console.WriteLine(" NO HAY TRIANGULOS EN LA COLECCION ");
                }
            }

            static void CrearTriangulos(List<Triangulo> objTriangulo)
            {
                if (objTriangulo.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"SE CREARON --- {objTriangulo.Count} --- TRIANGULOS");

                    int i = 1;

                    foreach (Triangulo auxTriangulo in objTriangulo)
                    {
                        Console.WriteLine($"TRIANGULO N° : {i++} \n");

                        Console.WriteLine(auxTriangulo.ToString());

                    }

                }
            }
        }
    }
}

