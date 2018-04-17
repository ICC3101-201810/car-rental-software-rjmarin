using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Moto : Vehiculo
    {
        string licencia = "C";
        string tipo;

        public Moto(int miAño, string miNombre, string miPatente, string miModelo) : base(miAño, miNombre, miPatente, miModelo)
        {
            
        }
    }
}
