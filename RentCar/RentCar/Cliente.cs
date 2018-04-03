using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Cliente
    {
        private string  nombre;

        public   Cliente(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
