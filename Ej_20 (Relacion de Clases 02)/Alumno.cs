using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_20__Relacion_de_Clases_02_
{
    class Alumno
    {
        /*  De cada alumno se conoce el nombre y una lista con las notas obtenidas en el curso.
        Se pide hacer un programa y las clases que necesite para: */

        private string nombre;
        private int idCurso;
        private int idAlumno;
        private double promedio_Final;
        private int cont_desaprobados;
   
        private List<Nota> listaNotas = new List<Nota>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int Cont_desaprobados { get => cont_desaprobados; set => cont_desaprobados = value; }
        public double Promedio_Final { get => promedio_Final; set => promedio_Final = value; }
        internal List<Nota> ListaNotas { get => listaNotas; set => listaNotas = value; }

        public Alumno ()
        {
           
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("\n Ingrese Nombre y apellido del alumno: ");
                this.Nombre = Console.ReadLine();

        }

        public void AsociarNota(int idcurso, double nota, int idalumno)
        {

            ListaNotas.Add(new Nota(idcurso, nota, idalumno));
        }

        

        public void CalcularPromedio()
        {
            foreach (Nota resultado in ListaNotas)
            {
                promedio_Final += resultado.Notas;
            }

            promedio_Final = promedio_Final / ListaNotas.Count;
        }
    
        public override string ToString()
        {
            if (promedio_Final == 0)
            {
                return ($" Nombre: {this.Nombre} \n Nota no ingresada");
            }
            else
            {
                return ($" Nombre: {this.Nombre} \n Nota: {this.promedio_Final} ");
            }
        }

        

    }
}
