using System;
using System.Collections.Generic;

namespace Ej_16_CAbs_Figura_Geometrica_
{
    class Ejecutora
    {
        /* 

               1. Un profesor de matemática pidió a sus alumnos hacer un programa que permita calcular algunas
      operaciones relacionadas con figuras geométricas. Para realizar esta tarea dio las siguientes consignas:
      El programa debe trabajar con los siguientes objetos: Triángulos, Rectángulos, Cuadrados y Círculos.
      Las operaciones disponibles para cada una de las Figuras geométricas son: superficie() y
      perímetro() en el caso del circulo su equivalente que es la longitud de la circunferencia.
      1. Se pide identificar todas las clases y construir el diagrama con la jerarquía de herencia
      correspondiente.
      Realizar un programa que a través de un menú pueda:
      • Cargar en una colección todas las figuras geométricas seleccionadas por el usuario.
      • Consultar los elementos de la colección
      • Informar la superficie total de todos los objetos de la colección
      • Mostrar todos los atributos de cada objeto de la colección (Atributos de las figuras
      • geométrica)


       */
        static void Main(string[] args)
        {

            List<FiguraGeometrica> objfigura = new List<FiguraGeometrica>();

            int opcion = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("BIENVENIDO AL PROGRAMA. INTRODUCCION DE FIGURAS GEOEMTRICAS");

            Menuopciones(opcion, objfigura);

        }

        public static void Menuopciones(int opcion, List<FiguraGeometrica> objfigurageometrica)
        {


            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 1. Agregar Figura geometrica \n 2. Mostrar listas \n 3. Mostrar superficie de todas las figuras ingresadas \n 4. Mostrar el perimetro de todas las figuras ingresadas \n 5. Salir \n");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:

                        AgregarFigurageometrica(objfigurageometrica);

                        break;


                    case 2:

                        MostrarLista(objfigurageometrica);


                        break;

                    case 3:


                        MostrarMaximoSuper(objfigurageometrica);

                        break;

                    case 4:

                        MostrarMaximoPerimetro(objfigurageometrica);


                        break;

                    case 5:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FIN DEL PROGRAMA");

                        break;

                    default:

                        Console.WriteLine("OPCION INCORRECTA, RE INGRESE OPCION CORRECTA");
                        break;
                }
            } while (opcion != 5);
        }


        public static void AgregarFigurageometrica(List<FiguraGeometrica> objfigurageo)
        {
            char sigue = 'S';


            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("\n Ingrese figura geometrica a cargar: 1. Cuadrado \t 2. Rectangulo  \t 3. Triangulo \t 4. circulo");
                int opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                if (opcion == 1)
                {

                    objfigurageo.Add(new Cuadrado());



                }
                else
                {
                    if (opcion == 2)
                    {
                        objfigurageo.Add(new Rectangulo());

                    }
                    else
                    {
                        if (opcion == 3)
                        {
                            objfigurageo.Add(new Triangulo());
                        }
                        else
                        {
                            if (opcion == 4)
                            {
                                objfigurageo.Add(new Circulo());
                            }
                        }
                    }
                }


                Console.WriteLine("\n Ingrese S para continuar con la carga de FIGURAS GEOMETRICAS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());

            }


        }

        public static void MostrarMaximoSuper(List<FiguraGeometrica> objfigurageo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n El maximo superficie de todas las figuras geometricas es:{FiguraGeometrica.SuperficieTotal} \n");
        }

        public static void MostrarMaximoPerimetro(List<FiguraGeometrica> objfigurageo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n  El maximo perimetro de todas las figuras geometricas es:{FiguraGeometrica.PerimetroTotal} \n");
        }

        public static void MostrarLista(List<FiguraGeometrica> objfigurageo)
        {
            if (objfigurageo.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\n EN LISTA HAY  --- {objfigurageo.Count} --- FIGURAS GEOMETRICAS \n");

                int i = 1;

                foreach (FiguraGeometrica vend in objfigurageo)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"N°: {i++}. {vend.ToString()} \n ");

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

