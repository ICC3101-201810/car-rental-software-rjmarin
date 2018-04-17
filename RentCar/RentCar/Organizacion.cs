using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Organizacion : Cliente
    {
        bool permiso;

         public Organizacion(bool miPermiso, string miNombre, int miId) : base(miNombre, miId)
        {
            permiso = miPermiso;

        }
    }
}
