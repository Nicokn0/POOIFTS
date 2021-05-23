using System;
using System.Collections.Generic;

namespace Ej_12__Coleccciones_Rectangulo_
{
    class EjecutoraRectangulo
    {
        /*

        2. Siguiendo la pauta del ejemplo resuelto adaptar el ejercicio 5 de la unidad 2 para poder almacenar el tipo de 
        objeto en una colección permitiendo agregar, eliminar y listar todos los objetos de la colección del RECTANGULO

        */
        static void Main(string[] args)
        {
            List<Rectangulo> objRectangulo = new List<Rectangulo>();
            int opcion = 0;

            do
            {
                Menu();
                Console.WriteLine("\n");
                opcion = int.Parse(Console.ReadLine());

                Menuopciones(opcion, objRectangulo);


            }
            while (opcion != 4);
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string menu = ("\n -1- Agregar Rectangulo \n -2- Eliminar Rectangulo  \n -3- Listar todos \n -4- Terminar programa \n");

            Console.WriteLine(menu);

        }

        public static void Menuopciones(int opcion, List<Rectangulo> objrectangulo)
        {


            switch (opcion)
            {
                case 1:

                    AgregarRectangulo(objrectangulo);

                    break;


                case 2:


                    BorrarRectangulo(objrectangulo);

                    break;

                case 3:


                    ListaRect(objrectangulo);

                    break;

                case 4:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FIN DEL PROGRAMA");

                    break;

                default:

                    Console.WriteLine("OPCION INCORRECTA, RE INGRESE OPCION CORRECTA");
                    break;
            }


        }

        static void AgregarRectangulo(List<Rectangulo> objrectangulo)
        {
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Console.WriteLine("\t Ingrese información del RECTANGULO \n");
                objrectangulo.Add(new Rectangulo());

                Console.WriteLine("Ingrese S para continuar con la carga de los RECTANGULOS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void BorrarRectangulo(List<Rectangulo> objrectangulo)
        {
            int sele_rect = 0;

            if (objrectangulo.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Seleccione el RECTANGULO a eliminar \n");

                    ListaRect(objrectangulo);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número del rectangulo a ELIMINAR:  ");
                    sele_rect = int.Parse(Console.ReadLine());

                    sele_rect--;

                } while (sele_rect < 0 || sele_rect > objrectangulo.Count);

                objrectangulo.RemoveAt(sele_rect);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Se elimino el RECTANGULO correctamente \n");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }

        }

        static void ListaRect(List<Rectangulo> objrectangulo)
        {
            if (objrectangulo.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"SE CREARON --- {objrectangulo.Count} --- RECTANGULOS");

                int i = 1;

                foreach (Rectangulo auxrect in objrectangulo)
                {
                    Console.WriteLine($" \n RECTANGULO N° : {i++} \n {auxrect.ToString()}");



                }

            }
        }



    }
}
