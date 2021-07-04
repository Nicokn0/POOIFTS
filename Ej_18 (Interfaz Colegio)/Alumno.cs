using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_18__Interfaz_Colegio_
{
    class Alumno : Persona, ItfEdad, IComparable, IRecreo
    {
        private int num_legajo;
        private string ingreso_escuela;
        private string egreso_fecha;
        private int tiempo_escuela;
        private bool egresado = false;

        public int Tiempo_escuela { get => tiempo_escuela; set => tiempo_escuela = value; }
        public int Num_legajo { get => num_legajo; set => num_legajo = value; }
        public string Egreso_fecha { get => egreso_fecha; set => egreso_fecha = value; }
        public string Ingreso_escuela { get => ingreso_escuela; set => ingreso_escuela = value; }

        public Alumno()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Ingrese el número de Legajo del Alumno: ");
            num_legajo = int.Parse(Console.ReadLine());

            Console.Write("\n Ingrese DD / MM / AAAA. Ingreso del alumno a la institución: ");
            ingreso_escuela = Console.ReadLine();

            Console.Write("\n El alumno es EGRESADO, INDIQUE SI o NO: ");

            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.egresado = true;

                if (egresado)
                {
                    Console.WriteLine(" \n Ingrese DD / MM / AAAA. Egreso del alumno de la institución: ");
                    egreso_fecha = Console.ReadLine();

                   
                }

            }

        }

        public override string ToString()
        {
            DateTime nacimiento = DateTime.Parse(Fecha_naciemiento); // Nacimiento
            DateTime ingreso_colegio = DateTime.Parse(ingreso_escuela); // ingreso a la escuela 
            DateTime fechaActual = DateTime.Now;

            if (egresado)
            {
                DateTime fecha_egreso = DateTime.Parse(egreso_fecha); // me convierte el string en fecha 
                Console.WriteLine($"\n Alumno egresado: {fecha_egreso}");

            }
            return ($" {base.ToString()} \n Edad: {CalcularEdad(nacimiento, fechaActual)} \n Número de Legajo: {Num_legajo} \n Ingreso a la Institución: {ingreso_escuela} \n Tiempo en la escuela: { CalcularIngresoEscuela(ingreso_colegio)} \n {LugarRecreo()}");
        }

        public string CalcularIngresoEscuela(DateTime FechaIngreso)
        {

            DateTime FechaActual = DateTime.Today;
            tiempo_escuela = 0;

            // Comprueba que la se haya introducido una fecha válida; si 
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje 
            // de advertencia:
            if (FechaIngreso > FechaActual)
            {
                return ("\n La fecha ingresada no corresponde a ningun alumno ya que se encuentra fuera de rango.");

            }
            else
            {
                tiempo_escuela = FechaActual.Year - FechaIngreso.Year;

                if (tiempo_escuela == 0)
                {
                    tiempo_escuela = FechaActual.Month - FechaIngreso.Month;

                    return ($"{tiempo_escuela} meses");

                }
                else
                {

                    if (FechaIngreso.Month > FechaActual.Month && FechaActual > FechaIngreso)
                    {
                        --tiempo_escuela;
                    }

                    else
                    {
                        if (FechaIngreso.Day >= FechaActual.Day)
                        {

                            --tiempo_escuela;
                        }
                    }
                }


            }

            return ($" {tiempo_escuela} años");
        }
       
        public string CalcularEdad(DateTime FechaNacimiento, DateTime FechaActual)
        {
            if (FechaNacimiento > FechaActual)
            {

                return ("La fecha de nacimiento es mayor que la actual.");
            }
            else
            {
                Age = FechaActual.Year - FechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor 
                // que el mes de la fecha actual:

                if (FechaNacimiento.Month > FechaActual.Month)
                {
                    --Age;
                }

                else
                {
                    if (FechaNacimiento.Day > FechaActual.Day)
                    {
                        --Age;
                    }
                }
                return ($"{Age}");
            }
        }
        ////// Arriba metodos de la interfaz. Abajo Interfaz de defecto

        public int CompareTo(object objalumno)
        {
            return (this.Age.CompareTo((objalumno as Alumno).Age));
        }

        public string LugarRecreo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return ("RECREO EN PATIO DE COLEGIO \n FIN DE CARGA DE DOCENTE \n");

        }
    }
}
