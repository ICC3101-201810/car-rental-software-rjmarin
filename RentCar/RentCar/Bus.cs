using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Bus: Vehiculo
    {
        string licencia = "A3";
        string tipo;

        public Bus(int miAño, string miNombre, string miPatente, string miModelo) : base(miAño, miNombre, miPatente, miModelo)
        {
           
        }
    }
}
