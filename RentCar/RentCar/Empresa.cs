using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Empresa: Cliente
    {
         bool permiso;
         
        public Empresa(bool miPermiso, string miNombre, int miId): base(miNombre,miId)
        {
            permiso = miPermiso;
            
        }
    }
}
