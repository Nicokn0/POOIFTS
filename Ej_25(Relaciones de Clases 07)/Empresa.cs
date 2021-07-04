using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_25_Relaciones_de_Clases_07_
{
    class Empresa
    {

        private string nombreEmpresa;
        private int cuit;
        private List<Empleado> listaEmpleado = new List<Empleado>();


        public int Cuit { get => cuit; set => cuit = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }

        public Empresa()
        {
            Console.Write("\n Ingrese nombre de la empresa: ");
            NombreEmpresa = Console.ReadLine();

            Console.Write("\n Ingrese numero de CUIT: ");
            Cuit = int.Parse(Console.ReadLine());
        }

        public void AgregarEmpleado()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine($"\n 1- Empleado Operario\n 2- Empleado Administrativo \n 3. Empleado Profesional");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    listaEmpleado.Add(new Operario());
                }
                else if (opcion == 2)
                {
                    listaEmpleado.Add(new Administrativo());
                }
                else if (opcion == 3)
                {
                    listaEmpleado.Add(new Profesional());
                }

            } while (opcion < 1 && opcion > 3);
        }


        public void EliminarEmpleado()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n Lista de empleados de la empresa: {this.nombreEmpresa} \t CUIT: {this.cuit} \n");
            ListarEmpleados();


            if (listaEmpleado.Count > 0)
            {
                Console.Write("\n Ingrese DNI del empleado: ");
                int doc = int.Parse(Console.ReadLine());

                listaEmpleado.Remove(listaEmpleado.Find(x => x.Dni == doc));

                Console.WriteLine("\n EMPLEADO ELIMINADO \n ");
            }


        }

        public void SueldoEmpleado()
        {
            if (listaEmpleado.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Lista de empleados de la empresa: {this.nombreEmpresa} \t CUIT:  {this.cuit} \n");
                ListarEmpleados();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Ingrese DNI del empleado");
                int doc = int.Parse(Console.ReadLine());
                Empleado em = listaEmpleado.Find(x => x.Dni == doc);

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(em.ToString());
            }
            else
            {
                Console.WriteLine("No hay empleados cargados");
            }


        }

        public void ListarEmpleados()
        {
            if (listaEmpleado.Count > 0)
            {
                foreach (Empleado emp in listaEmpleado)
                {
                    Console.WriteLine(emp.ToString());

                    Console.WriteLine("\n");
                }

            }
            else
            {
                Console.WriteLine("No hay empleados cargados");
            }
        }
    }
}
