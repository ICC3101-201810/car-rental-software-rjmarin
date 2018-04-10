using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Sucursal
    {
        public string nombre;
        public string direccion;
        public int rut;
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public Sucursal(string miNombre,string miDireccion, int miRut, List<Vehiculo> miVehiculos)
        {
            nombre = miNombre;
            direccion = miDireccion;
            rut = miRut;
            vehiculos = miVehiculos;
            
            
        }
        public void Agregarvehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
    }

}
