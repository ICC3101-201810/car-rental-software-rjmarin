using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Arriendo
    {
        List<Sucursal> su = new List<Sucursal>();
        List<Vehiculo> ve = new List<Vehiculo>();
       
        Cliente cliente;

        public Arriendo(List<Sucursal> su, List<Vehiculo> ve,  Cliente cliente)
        {
            this.su = su;
            this.ve = ve;
            
            this.cliente = cliente;
        }
    }
}
