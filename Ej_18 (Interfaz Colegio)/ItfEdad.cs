using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_18__Interfaz_Colegio_
{
    interface ItfEdad 
    {
        string CalcularEdad(DateTime Fechanacimiento, DateTime FechaActual);
       
        string AñosEscuela(DateTime FechaIngreso);
    }
}
