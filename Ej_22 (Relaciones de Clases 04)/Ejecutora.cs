using System;
using System.Collections.Generic;

namespace Ej_22__Relaciones_de_Clases_04_
{
    class Ejecutora
    {
        /*
        
            4) Una empresa de distribución lleva encomiendas a todo el país. Todas ellos tienen un número, remitente, 
            destinatario, destino y peso en kg.
        
            De cada destino al que llegan se conoce localidad, provincia y km. a los que dista 
            desde la empresa. 
        
            El costo del envío se establece cobrando $15 si la distancia es hasta 100 km, $25 hasta 400 km y $40 
            para distancias mayores, se le suman además $2 por kg ó fracción. Definir las clases necesarias y escribir los métodos 
            para programar los siguientes casos de uso: 

            a) Agregar una nueva encomienda a llevar. Verificar que exista el destino solicitado.
            b) Informar el costo de una encomienda dado su número. 
            c) Retirar todas las encomiendas pendientes de un destino dado, porque serán entregadas. Informar el nro. de cada una 
            de ellas. 
         */
        static void Main(string[] args)
        {

            int opc = 0;
            List<Destino> listaDestino = new List<Destino>();
            List<Encomienda> listaEncomiendas = new List<Encomienda>();
            do
            {

                Console.WriteLine("1-Cargar Destinos\n2-Agregar Encomienda\n3-Valor de encomienda\n4-Encomiendas entregadas\n0-Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        listaDestino.Add(new Destino());

                        break;

                    case 2:

                        Console.WriteLine("Ingrese Destino en caso de que no se encuentre el destino ingrese 999 para crearlo");
                        RetornarDestino(listaDestino);
                        int op = int.Parse(Console.ReadLine());
                        if (op != 999)
                        {
                            Destino d = listaDestino[op];
                            Encomienda e = new Encomienda(d);
                            listaDestino[op].ListaEncomienda.Add(e);
                            listaEncomiendas.Add(e);
                        }
                        else
                        {
                            AgregarDestino(listaDestino);
                        }

                        break;
                    case 3:
                        RetornarPrecio(listaEncomiendas);
                        break;
                    case 4:
                        RetirarEnomiendas(listaDestino);
                        break;

                    default:
                        Console.WriteLine("Hasta luego");
                        break;
                }

            } while (opc != 0);
        }

        public static void AgregarDestino(List<Destino> d)
        {
            d.Add(new Destino());
        }

        public static void RetornarDestino(List<Destino> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i}- {lista[i].ToString()}");
            }

        }

        public static void RetornarPrecio(List<Encomienda> d)
        {
            foreach (Encomienda des in d)
            {
                Console.WriteLine($"{des.Nro}- {des.Destinatario}");
            }
            Console.WriteLine("Seleccione el numero de encomienda para saber el precio");
            d[int.Parse(Console.ReadLine())].CostoEnvio();

        }

        public static void RetirarEnomiendas(List<Destino> d)
        {
            RetornarDestino(d);
            Console.WriteLine("Ingrese destino");
            int des = int.Parse(Console.ReadLine());

            for (int i = 0; i < d[des].ListaEncomienda.Count; i++)
            {
                Console.WriteLine($"{d[des].ListaEncomienda[i].ToString()}");
                d[des].ListaEncomienda.RemoveAt(i);
            }

            Console.WriteLine("Las encomiendas han sido entregadas");


        }
    }
}
