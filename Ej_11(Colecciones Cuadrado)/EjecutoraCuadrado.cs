using System;
using System.Collections.Generic;
namespace Ej_11_Colecciones_Cuadrado_
{
    class EjecutoraCuadrado
    {
        static void Main(string[] args)
        {

            List<Cuadrado> objCuadrado = new List<Cuadrado>(); //Creo una lista objCuadrado
            int opcion = 0;

            do
            {
                Menu(); // 1 Metodo MENU 
                Console.WriteLine("\n");
                opcion = int.Parse(Console.ReadLine());

                Opciones(opcion, objCuadrado); //Opciones a desarrollar Ej agregar, eliminar y le paso la lista


            }
            while (opcion != 4);
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string menu = ("\n -1- Agregar CUADRADO \n -2- Eliminar CUADRADO  \n -3- Listar todos \n -4- Terminar programa \n");

            Console.WriteLine(menu);

        }

        public static void Opciones(int opcion, List<Cuadrado> objCuadrado)
        {


            switch (opcion)
            {
                case 1:

                    AgregarCuadrado(objCuadrado); //Llamo al Metodo Agregar CUadrado 

                    break;


                case 2:


                    BorrarCuadrado(objCuadrado);

                    break;

                case 3:


                    ListaCuadrado(objCuadrado);

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


        static void AgregarCuadrado(List<Cuadrado> objcuadrado) // Aca dentro vas hacer una lista Tipo de dato una Lista
        {
            char sigue = 'S';

            while (sigue.ToString().ToUpper().Equals("S"))
            {
                
                objcuadrado.Add(new Cuadrado()); //Agregame a la variable objcuadrado lo que tengas en la clase CUADRADO.

                Console.WriteLine("Ingrese S para continuar con la carga de los Cuadrados. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());
            }
        }

        static void BorrarCuadrado(List<Cuadrado> objCuadrado)
        {
            int sele_cuadrado = 0;

            if (objCuadrado.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Seleccione el cuadrado a eliminar \n");

                    ListaCuadrado(objCuadrado);
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n INGRESE el número del CUADRADO a ELIMINAR:  ");
                    sele_cuadrado = int.Parse(Console.ReadLine());

                    sele_cuadrado--;

                } while (sele_cuadrado < 0 || sele_cuadrado > objCuadrado.Count);

                objCuadrado.RemoveAt(sele_cuadrado);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Se elimino el CUADRADO correctamente \n");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE CARGO NINGUN ELEMENTO");
            }

        }

        static void ListaCuadrado(List<Cuadrado> objcuadrado) // List tiene que estar si o si!! Sino no te crea la lista 
        {
            if (objcuadrado.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"SE CREARON --- {objcuadrado.Count} --- CUADRADOS \n");

                int i = 1;

                foreach (Cuadrado auxcuadrado in objcuadrado) // RECORRER LISTA. 1 LLAMO A LA CLASE, LE PONGO NOMBRE A LA VARIABLE AUXRECT y le digo que recorrala lista
                {
                    Console.WriteLine($" \n CUADRADO N° : {i++} \n {auxcuadrado.ToString()}");



                }

            }
            else
            {
                Console.WriteLine("NO HAY CUADRADOS EN LA LISTA");
            }
        }
    }
}
    
