using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_26__Trabajado_en_Clase_01_
{
    class Auto
    {
        // defino los atributos que definen a un auto

        private int motor;
        private int carroceria;
        private int rueda;
        private string chasis;
        private int volante;
        private string espejo;
        private string luces;
        private string bateria;

        public int Motor { get => motor; set => motor = value; }

        // programacion de accesos utilizando getters y setters a mano
        public int Carroceria() // getter obtiene un valor de un atributo, en este caso de carroceria
        {
            return this.carroceria;
        }

        public void Carroceria(int valorCarroceria)
        {
            this.carroceria = valorCarroceria;
        }

        public int Rueda { get => rueda; set => rueda = value; }
        public string Chasis { get => chasis; set => chasis = value; }
        public int Volante { get => volante; set => volante = value; }
        public string Espejo { get => espejo; set => espejo = value; }
        public string Luces { get => luces; set => luces = value; }
        public string Bateria { get => bateria; set => bateria = value; }


        public override string ToString()
        {
            return ($"número de motor:{this.motor}\nnúmero de carrocería: {this.carroceria}\nTipo de Espejo:{this.espejo}");
        }

        public string DatosDelAuto()
        {
            return ($"Bateria:{this.bateria}\nCarroceria: {this.carroceria}\nChasis:{this.chasis}");
        }
    }
}
