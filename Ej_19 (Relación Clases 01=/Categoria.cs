using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_19__Relación_Clases_01_
{
    class Categoria //Agregación con respecto a Alumno
    {

        /*
         La clase Categoria Tiene los atributos idCategoria int, descripcion String. El método descripcion devuelve la descripcion 
         de la categoría. 

         */

        private string descrip;
        int idCategoria;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Descrip { get => descrip; set => descrip = value; }

        public Categoria(int id, string categoria)
        {
            this.Descrip = categoria;
            this.IdCategoria = id;
        }

        public string Descripcion() //devuelve la descripcion de la categoría
        {
            return ($"Categoría: {this.Descrip}");
        }

    }
}
