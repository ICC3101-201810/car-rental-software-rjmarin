using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Empresa: Cliente
    {
         private bool permiso;

        public bool Permiso { get => permiso; set => permiso = value; }

        public Empresa(bool permiso, string nombre): base(nombre)
        {
            Permiso = permiso;
            
        }
    }
}
