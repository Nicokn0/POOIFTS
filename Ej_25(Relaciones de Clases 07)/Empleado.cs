using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_25_Relaciones_de_Clases_07_
{
    public abstract class Empleado
    {
        private string nombre;
        private int dni;
        private double sueldoBasico;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public Empleado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Ingrese nombre del empleado: ");
            this.nombre = Console.ReadLine();

            Console.Write("\n Ingrese DNI del empleado: ");
            this.dni = int.Parse(Console.ReadLine());

            Console.Write("\n Ingrese Sueldo Basico del empleado: ");
            this.sueldoBasico = double.Parse(Console.ReadLine());
        }

        public abstract double CalcularSueldo();

        public override string ToString()
        {
            return $"Empleado: {Nombre} DNI: {Dni} Cobra: ${CalcularSueldo()}";
        }
    }
}