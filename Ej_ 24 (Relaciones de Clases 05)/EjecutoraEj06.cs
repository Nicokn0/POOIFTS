using System;

namespace Ej__24__Relaciones_de_Clases_05_
{
    class EjecutoraEj06
    {

        /* 
                 6) De una empresa se conoce su nombre, su número de CUIT y todos los empleados que trabajan el ella. Estos 
        empleados están clasificados en administrativos y operarios. De cada empleado se conoce: nombre, número de 
        documento y el sueldo básico. Los operarios cobran un incentivo que se adiciona al básico. De los administrativos se 
        conoce las horas extras que realizan, que a un valor de $50 la hora, se adicionan al básico. Se pide hacer un programa y 
        las clases que necesite para: 
       
        
        a) Agregar un empleado nuevo. 
        b) Eliminar un empleado dado su número de documento. 
        c) Dado un número de documento, informar cuánto va a cobrar dicho empleado
         
         */
        static void Main(string[] args)
        {
            int opcion;
            string msj = "\n 1. Agregar Empleado \n 2. Eliminar Empleado \n 3. Informar sueldo \n 0. Salir \n";
            Empresa ObjEmpresa = new Empresa();

            do
            {

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(msj);
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        ObjEmpresa.AgregarEmpleado(); 

                        break;

                    case 2:

                        Console.ForegroundColor = ConsoleColor.Red;
                        ObjEmpresa.EliminarEmpleado();

                        break;

                    case 3:


                        Console.ForegroundColor = ConsoleColor.Green;

                        ObjEmpresa.SueldoEmpleado();

                        break;

                    default:

                        Console.WriteLine("Hasta luego");

                        break;
                }

            } while (opcion != 0);
        }

     
    }
}
