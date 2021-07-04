using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_20__Relacion_de_Clases_02_
{
    class Nota
    {

        private int idCursoAsociado;
        private int idAlumnoAsociado;
        private double notas;

        public int IdCursoAsociado { get => idCursoAsociado; set => idCursoAsociado = value; }
        public int IdAlumnoAsociado { get => idAlumnoAsociado; set => idAlumnoAsociado = value; }
        public double Notas { get => notas; set => notas = value; }

        public Nota(int curso, double nota, int alumno)
        {
            this.IdAlumnoAsociado = alumno;
            this.IdCursoAsociado = curso;
            this.Notas = nota;
        }

    

    }
}
