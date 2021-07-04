using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_20__Relacion_de_Clases_02_
{
    class Curso
    {
        private int idCurso;
        private string descrip;
        private List<Alumno> list_objAlu = new List<Alumno>();

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public List<Alumno> List_objAlu { get => list_objAlu; set => list_objAlu = value; }

        public Curso(int id)
        {
            Console.Write( "\n  Nombre del curso: ");
            this.descrip = Console.ReadLine();
            this.idCurso = id ;

        }

        public void ImprimirInfo () //Devuelve la descripción del curso
        {
            Console.WriteLine($"ID: {this.IdCurso} \t Curso: {this.descrip} ");


            foreach (Alumno alu in List_objAlu)
            {
                Console.WriteLine(list_objAlu.ToString());
                if (alu is Alumno)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Alumno alumAux = (Alumno)alu;
                    Console.WriteLine(alumAux.ToString());


                }
            }
          
        }

        public void AgregarAlumno (Alumno listaAlumno)
        {
            list_objAlu.Add(listaAlumno);
        }

        public override string ToString()
        {
            return $" \n ID: {idCurso} \t Curso: {descrip}";
        }

        public void CompararPromedio()
        {
            if (list_objAlu.Count > 0)
            {
                string nombre = list_objAlu[0].Nombre; // Llamo al nombre del alumno 

                double guardarProm = list_objAlu[0].Promedio_Final;

                for (int i = 0; i < list_objAlu.Count; i++)
                {

                    if (guardarProm < list_objAlu[i].Promedio_Final) // Comparo los promedios 
                    {
                        nombre = list_objAlu[i].Nombre;
                        guardarProm = list_objAlu[i].Promedio_Final;
                    }

                }

                Console.WriteLine($"El alumno con mayor promedio es: {nombre} con un promedio de {guardarProm}");
            }
            
            else
            {
                Console.WriteLine("No se cargo alumnos!!! Debe cargar alumnos para sacar promedio. ");
            }
        }
    }
    
}
