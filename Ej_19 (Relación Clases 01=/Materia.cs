using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_19__Relación_Clases_01_
{
    class Materia //Asociación con respecto a Ejecutora
    {

        /* La clase Materias Tiene los atributos idMateria int, descripcion String. 
         
            Tiene un método descripcion() El método descripcion devuelve la descripción de la materia. */

        private int idMateria;
        private string descrip;
        private List<Alumno> listaAlumno = new List<Alumno>();

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string Descrip { get => descrip; set => descrip = value; }


        public Materia(int id, string materia)
        {
            this.descrip = materia;
            this.idMateria = id;
        }

        public string Descripcion() //Devuelve la descripción de la materia
        {
            return ($"ID: {this.idMateria} \t Materia: {this.descrip}");
        }

        public void AgregarAlumnoALista(Alumno alum)
        {
            listaAlumno.Add(alum);
        }

    }
}
