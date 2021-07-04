using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_19__Relación_Clases_01_
{
    class Alumno
    {
        /*
           La clase Alumno tiene los atributos nombre String, domicilio Domicilio , IdCategoria int e idMateria int.
              
                Tiene los métodos materiasCursadas(), domicilio() y categoría() 
                El método materias cursadas devuelve todas las materias asociadas al alumno
                El método domicilio devuelve el domicilio del alumno
                El método categoría devuelve la categoría del alumno 
        
         */

        private string nombre;
        private int idCategoria;
        private int idMateria;
        private int idAlumno;
        private static int contador_Alumno;
        public Domicilio Domicilio;

        
        private List<Materia> listaMaterias = new List<Materia>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }

        public Alumno (List<Categoria> lista_cat, List<Materia> lista_mat)
        {
           
           Console.WriteLine("Ingrese Nombre del ALumno");
           this.nombre = Console.ReadLine();

            this.idAlumno = contador_Alumno++;

           this.Domicilio = new Domicilio(); // Metodo Composición, Domicilio es una entidad debil con respecto a Alumno

        }

    
        public string domicilio ()
        {
            return this.Domicilio.domicilio(); // Da el metodo DOMICILIO desde la clase DOmicilio.
        }

     
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            return ($"\n ID: {this.idAlumno} Nombre: {this.nombre} \n --- Dirección --- {domicilio()} \n ");
        }

        public void AgregarMateriaAlumno(Materia materia)
        {
            listaMaterias.Add(materia);
        }

       
}
}
