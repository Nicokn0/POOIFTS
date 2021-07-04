using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ej_18__Interfaz_Colegio_
{
    class Docente : Persona, ItfEdad, IComparable, IRecreo
    {
        private string num_legajo;
        private string calculo_tescuela;
        private int tiempo_escuela;
      
    
        public string Num_legajo { get => num_legajo; set => num_legajo = value; }
        public string Calculo_tescuela { get => calculo_tescuela; set => calculo_tescuela = value; }
        public int Tiempo_escuela { get => tiempo_escuela; set => tiempo_escuela = value; }

        public Docente()
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n Ingrese Número de legajo: ");
            Num_legajo = Console.ReadLine();

            Console.Write("\n Ingrese día, mes y año (DD / MM / AAAA). Ingreso DOCENTE a la institución: ");
            calculo_tescuela = Console.ReadLine();

        }

        public override string ToString()
        {
            DateTime fechanacimiento = DateTime.Parse(Fecha_naciemiento); // Calcular edad
            DateTime fechaIngresoCole = DateTime.Parse(calculo_tescuela); // Calcular ingreso a la instititución
            DateTime fechaActual = DateTime.Today; //Calcular día actual


            return ($"{base.ToString()} \n Número de Legajo: {Num_legajo} \n Edad del Docente: {CalcularEdad(fechanacimiento, fechaActual)} años \n Ingreso a la Institución: {fechaIngresoCole}  \n Tiempo en la Institución: {CalcularIngresoEscuela(fechaIngresoCole)}  \n {LugarRecreo()}");
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

        public string CalcularIngresoEscuela(DateTime FechaIngreso)
        {

            DateTime FechaActual = DateTime.Today;
            

            // Comprueba que la se haya introducido una fecha válida; si 
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje 
            // de advertencia:
            if (FechaIngreso > FechaActual)
            {
                return ("La fecha ingresada no corresponde a ningun alumno ya que se encuentra fuera de rango.");

            }
            else
            {
                Tiempo_escuela = FechaActual.Year - FechaIngreso.Year;

                if (Tiempo_escuela == 0)
                {
                    Tiempo_escuela = FechaActual.Month - FechaIngreso.Month;

                    return ($"{Tiempo_escuela} meses");

                }
                else
                {

                    if (FechaIngreso.Month > FechaActual.Month && FechaActual > FechaIngreso)
                    {
                        --Tiempo_escuela;
                    }

                    else
                    {
                        if (FechaIngreso.Day >= FechaActual.Day)
                        {

                            --Tiempo_escuela;
                        }
                    }
                }


            }

            return ($" {Tiempo_escuela} años");
        }

        public  int CompareTo(object objDocente)
        {

            return (this.Age.CompareTo((objDocente as Docente).Age));
        }

        public string LugarRecreo ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
          return ("RECREO EN SALA DE MAESTRO \n FIN DE CARGA DE DOCENTE \n");
        }
      
    }

}