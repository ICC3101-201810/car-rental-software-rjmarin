using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Camion: Vehiculo
    {
        string licencia = "A5";
        string tipo;

        public Camion(int miAño, string miNombre, string miPatente, string miModelo) : base(miAño, miNombre, miPatente, miModelo)
        {
            
        }
    }
}
