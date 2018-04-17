using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Vehiculo
    {
         public string nombre;
         public int año;
         public string patente;


        public Vehiculo( int miAño, string miNombre, string miPatente)
        {
            
            año = miAño;
            nombre = miNombre;
            patente = miPatente;

            
            

        }
    }
}
