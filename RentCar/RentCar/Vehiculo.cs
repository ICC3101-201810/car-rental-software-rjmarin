using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Vehiculo
    {
        private string nombre;
        private int año;




        public int Año { get => año; set => año = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Vehiculo( int año, string nombre)
        {
            
            Año = año;
            Nombre = nombre;
            
            

        }
    }
}
