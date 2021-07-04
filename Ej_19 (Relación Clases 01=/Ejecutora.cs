using System;
using System.Collections.Generic;

namespace Ej_19__Relación_Clases_01_
{
    class Ejecutora
    {
        /* 
              La clase Alumno tiene los atributos nombre String, domicilio Domicilio , IdCategoria int e idMateria int.
              
                Tiene los métodos materiasCursadas(), domicilio() y categoría() 
                El método materias cursadas devuelve todas las materias asociadas al alumno
                El método domicilio devuelve el domicilio del alumno
                El método categoría devuelve la categoría del alumno 
        
              La clase Domicilio Tiene los atributos idDomicilio int, calle String, numero String, localidad String, provincia String. 
               
                Tiene un método domicilio() El método domicilio devuelve los datos formateados del domicilio . 
        
              La clase Materias Tiene los atributos idMateria int, descripcion String.
                
                Tiene un método descripcion() El método descripcion devuelve la descripción de la materia. 
       
              La clase Categoria Tiene los atributos idCategoria int, descripcion String. 
                
                El método descripcion devuelve la descripcion de la categoría. 


        Que debería hacer para poder listar todas las materias que estan siendo referenciadas por todos los alumnos? 
        Se pide crear una aplicación que cargue por menú todos los objetos, no existen limitaciones en cuanto a la cantidad de 
        objetos a crear. Las leyendas e ítems del menú quedan a criterio del alumno

         */
        static void Main(string[] args)
        {
            List<Alumno> ObjAlumno = new List<Alumno>();
            List<Categoria> ObjCategoria = new List<Categoria> ();
            List<Materia> ObjMateria = new List<Materia>();

          

            Menu(ObjAlumno, ObjCategoria, ObjMateria);
        }

        static void Menu (List<Alumno> ObjAlumno, List<Categoria> ObjCategoria, List<Materia> ObjMateria)
        {
            string msj1 = " \n 1. Ingrese Alumno \n 2. Ingrese Categoría \n 3. Ingrese Materia \n 4. Listar todas las materias \n 5. Listar Categorias Ingresadas \n 6. Listar Información Alumnos \n 7. Agregar alumno a Materia \n 8. Fin de programa ";
            int opcion =0;


            do
            {
                Console.WriteLine(msj1);
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (opcion)
                {
                    case 1:

                        AgregarAlumno(ObjAlumno, ObjMateria, ObjCategoria);
                        Console.Clear();

                        break;

                    case 2:

                        char sigue = 'S';

                        while (sigue.ToString().ToUpper().Equals("S"))
                        {
                            AgregarCategoria(ObjCategoria);
                            
                            Console.WriteLine("\n Ingrese S para continuar con carga de CATEGORIA. Cualquier otra tecla para finalizar");
                            sigue = char.Parse(Console.ReadLine()); 
                        }
                        Console.Clear();

                         break;

                    case 3:
                        
                        AgregarMateria(ObjMateria);
                        Console.Clear();
                        break;

                    case 4:

                        ListarMaterias(ObjMateria);
                        break;

                    case 5:

                         ListarCategoria(ObjCategoria);

                        break;

                    case 6:

                        ListarAlumnos(ObjAlumno);

                        break;

                    case 7:

                        Console.WriteLine("Ingrese número de ID del alumno al que quiera agregar a la materia \n ");
                        ListarAlumnos(ObjAlumno);

                        int opcion_A = int.Parse(Console.ReadLine());

                        ListarMaterias(ObjMateria);

                        Console.WriteLine("Ingrese ID, materia");
                        do
                        {
                            int opmat = int.Parse(Console.ReadLine());

                            ObjAlumno[opcion_A].AgregarMateriaAlumno(ObjMateria[opmat]);

                            ObjMateria[opmat].AgregarAlumnoALista(ObjAlumno[opcion_A]);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n Se agrego correctamente a la materia {ObjMateria[opmat].Descripcion()}");

                            Console.WriteLine("\n Desea seguir agregando materias SI/NO");

                        } while (Console.ReadLine().Equals("si", StringComparison.InvariantCultureIgnoreCase));


                        break;


                    case 8:
                        Console.WriteLine("Fin del programa");
                        break;

                    default:
                        Console.WriteLine( "Opción incorrecta, vuelva a elegir " );
                        break;
                }

            } 
            while (opcion != 8);
        }

        static void AgregarAlumno (List<Alumno> ObjAlumno, List<Materia> ObjMateria, List<Categoria> ObjCategoria)
        {
            char sigue = 'S';

            Console.ForegroundColor = ConsoleColor.Cyan;


            while (sigue.ToString().ToUpper().Equals("S"))
            {
                ObjAlumno.Add(new Alumno(ObjCategoria,ObjMateria));

                Console.WriteLine("\n");
                Console.WriteLine("\n Ingrese S para continuar con la carga de Alumnos. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());

            }

        }
       
        static void AgregarMateria(List<Materia> ObjMateria)
        {
            char sigue = 'S';

            Console.ForegroundColor = ConsoleColor.Cyan;


            while (sigue.ToString().ToUpper().Equals("S"))
            {
                Materia busq_materia;

                Console.Write("\n Ingrese el nombre de la materia: ");
                string materia = Console.ReadLine();

                busq_materia = ObjMateria.Find(x => x.Descrip.Contains(materia));

                if (busq_materia == null)
                {
                    ObjMateria.Add(new Materia(ObjMateria.Count, materia));
                }
                else
                {

                    Console.WriteLine("La materia ya existe.\n");
                }

                Console.WriteLine("\n Ingrese S para continuar con la carga de MATERIAS. Cualquier otra tecla para finalizar");
                sigue = char.Parse(Console.ReadLine());

            }

        }
       
        static void AgregarCategoria(List<Categoria> ObjCategoria)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;

           
                Categoria busq_categoria;

                Console.Write("\n Ingrese el  nombre de la categoría: ");
                string categoria = Console.ReadLine();

                busq_categoria = ObjCategoria.Find(x => x.Descrip.Contains(categoria)); //Metodo que me sirve pra buscar si la categoria que ingreso ya esta ingresada

                if (busq_categoria == null)
                {
                    ObjCategoria.Add(new Categoria(ObjCategoria.Count, categoria));

                }
                else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La categoría ya existe.");

                }

                

        }
       
        static void ListarAlumnos (List <Alumno> ObjAlumno)
        {
            if (ObjAlumno.Count > 0)
            {
                foreach (object obj in ObjAlumno)
                {
                 
                    if (obj is Alumno)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Alumno alumAux = (Alumno)obj;
                        Console.WriteLine(alumAux.ToString());
                        
                    }
                }

            }
            else
            {
                Console.WriteLine("No hay ALUMNOS en la colección");
                Console.ReadKey();
            }
        }
        
        static void ListarMaterias (List<Materia> ObjMateria)
        {
            if (ObjMateria.Count > 0)
            {
                foreach (object obj in ObjMateria)
                {
                    if (obj is Materia)
                    {
                        Materia matAux = (Materia)obj;

                        Console.WriteLine($"{matAux.Descripcion()} \n");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("No hay Materias en la colección");
                Console.ReadKey();
            }
        }

        static void ListarCategoria (List <Categoria> ObjCategoria)
        {
            if (ObjCategoria.Count > 0)
            {
                foreach (object obj in ObjCategoria)
                {
                    if (obj is Categoria)
                    {
                        Categoria catAux = (Categoria)obj;
                        Console.WriteLine($"{catAux.Descripcion()}\n");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("No hay Categorias en la colección");
                Console.ReadKey();
            }
        }
        
    }
}
