using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Program
    {
        enum Tipo { auto, acuático, moto, camion, bus, maquinariapesada }
        enum Accesorios { radios, GPS, ruedasextra, cortinas, sillas }
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(1979, "auto");
            List<Sucursal> su1 = new List<Sucursal>();
            Sucursal sucursal = new Sucursal("","");
            Vehiculo vehiculo = new Vehiculo(70, "");

            string numero;
            string Tupo;
            Console.WriteLine("Nombre de la sucursal");
            sucursal.nombre = Console.ReadLine();
            Console.WriteLine("Nombre la direccion de la sucursal");
            sucursal.direccion = Console.ReadLine();
            Console.WriteLine("que tipo de auto desea arrendar (ingrese numero)");
            foreach (string str in Enum.GetNames(typeof(Tipo)))
                Console.WriteLine(str +", numero:"+ Enum.GetValues(typeof(Tipo)));
            numero = Console.ReadLine();

            if (numero == "1")
            {
                Tupo = "auto";
            }
            if (numero == "2")
            {
                Tupo = "acuatico";
            }
            if (numero == "3")
            {
                Tupo = "moto";
            }
            if (numero == "4")
            {
                Tupo = "camion";
            }
            if (numero == "5")
            {
                Tupo = "bus";
            }
            if (numero == "6")
            {
                Tupo = "maquinaria pesada";
            }
            Console.WriteLine("Nombre del"+Tupo);
            vehiculo.Nombre = Console.ReadLine();
            Console.WriteLine("año del vehiculo");
            vehiculo.Año = Console.ReadLine();

        }
    }
}
