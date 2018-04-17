using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Maquinaria:Vehiculo
    {
        string licencia= "A4";
        string tipo;

        public Maquinaria(int miAño, string miNombre, string miPatente, string miModelo):base(miAño,  miNombre,  miPatente,  miModelo)
        {
            
        }
    }
}
