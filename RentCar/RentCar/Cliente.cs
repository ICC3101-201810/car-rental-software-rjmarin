using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
     abstract class Cliente
    {
        public string  nombre;
        public int id;

        public Cliente(string miNombre, int miId)
        {
            nombre = miNombre;
            id = miId;
        }
    }
}
