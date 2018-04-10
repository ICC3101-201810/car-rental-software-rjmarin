using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Arriendo
    {
        Sucursal sucursal;
        Vehiculo vehiculo;
        Cliente cliente;

        public Arriendo(Sucursal miSucursal, Vehiculo miVehiculo, Cliente Micliente)
        {
            sucursal = miSucursal;
            vehiculo = miVehiculo;
            cliente = Micliente;
            
            
        }
    }
}
