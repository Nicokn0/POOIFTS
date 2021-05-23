using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_09__Colecciones_Vendedor_
{
    class Comercio
    {

        private int numero_cuil;
        private string nombre_comercio;

        public int Numero_cuil()
        {
            return numero_cuil;
        }

        public void Numero_cuil(int numerocuil)
        {
            this.numero_cuil = numerocuil;
        }

        public string Nombre_comercio()
        {
            return nombre_comercio;
        }

        public void Nombre_comercio(string nombre_empresa)
        {
            this.nombre_comercio = nombre_empresa;
        }

    }
}
