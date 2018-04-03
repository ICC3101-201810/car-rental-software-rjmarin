using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Persona:Cliente
    {
        private bool licencia;

        public bool Licencia { get => licencia; set => licencia = value; }

        public Persona(bool licencia, string nombre): base(nombre)
        {
            Licencia = licencia;
            Nombre = nombre;
        }
    }
}
