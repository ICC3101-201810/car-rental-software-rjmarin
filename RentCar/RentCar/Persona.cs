using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Persona:Cliente
    {
        public  bool licencia;

        

        public Persona(bool miLicencia, string miNombre,int miId): base(miNombre,miId)
        {
            licencia = miLicencia;
            
        }
    }

}
