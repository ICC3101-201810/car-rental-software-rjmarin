using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Acuatico: Vehiculo
    {
        string licencia = "1";
        string tipo;

        public Acuatico(int miAño, string miNombre, string miPatente, string miModelo) : base(miAño, miNombre, miPatente, miModelo)
        {
           
        }
    }
}
