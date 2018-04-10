using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Vehiculo
    {
         string nombre;
         int año;
        string tipo;


        public Vehiculo( int miAño, string miNombre, string miTipo)
        {
            
            año = miAño;
            nombre = miNombre;
            tipo = miTipo;

            
            

        }
    }
}
