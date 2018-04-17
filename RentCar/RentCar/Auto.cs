using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Auto :Vehiculo
    {

        bool asiento_extra;
        bool maletero;
        string tipo;

        public Auto(int miAño, string miNombre, string miPatente, string miModelo, bool asiento, bool miMaletero) : base(miAño, miNombre, miPatente, miModelo)
        {
            asiento_extra = asiento;
            maletero = miMaletero;
        }
    }
}
