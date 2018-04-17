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
        public List<Vehiculo> vehiculos = new List<Vehiculo>();

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
        public Vehiculo Crearvehiculo()
        {
            string nom, paten, model,tipo;
            int año;
            Console.WriteLine("escriba tipo de vehiculo");
            tipo = Console.ReadLine();
            if (tipo== "auto")
            {
                Console.WriteLine("nombre del auto");
                nom = Console.ReadLine();
                Console.WriteLine("patente del auto");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del auto");
                model = Console.ReadLine();
                Console.WriteLine("año del auto");
                año = Int32.Parse(Console.ReadLine());
                Console.WriteLine("tiene corrida de asiento extra (1)SI   (2)NO");
                int num = Int32.Parse(Console.ReadLine());
                bool a, b;
                if (num == 1) { a = true; }
                else { a = false; }
                Console.WriteLine("tiene un maletero grande (1)SI   (2)NO");
                int num1 = Int32.Parse(Console.ReadLine());
                if (num == 1) { b = true; }
                else { b = false; }
                Vehiculo v1 = new Auto(año, nom, paten, model, a, b);
                return v1;
            }
            else
            {
                Console.WriteLine("nombre del vehiculo");
                nom = Console.ReadLine();
                Console.WriteLine("patente del vehiculo");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del vehiculo");
                model = Console.ReadLine();
                Console.WriteLine("año del vehiculo");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Vehiculo(año, nom, paten, model);
                return v1;
            }
            



        }
        public Vehiculo devolvervehiculo()
        {
            string nom, paten, model;
            int año;
            string tipo;
            tipo = Console.ReadLine();
            if (tipo == "maquinaria")
            {
                Console.WriteLine("nombre de la maquinaria");
                nom = Console.ReadLine();
                Console.WriteLine("patente de la maquinaria");
                paten = Console.ReadLine();
                Console.WriteLine("modelo de la maquinaria");
                model = Console.ReadLine();
                Console.WriteLine("año de la maquinaria");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Maquinaria(año, nom, paten, model);
                return v1;
            }
            else if (tipo == "camion")
            {
                Console.WriteLine("nombre del camion");
                nom = Console.ReadLine();
                Console.WriteLine("patente del camion");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del camion");
                model = Console.ReadLine();
                Console.WriteLine("año del camion");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Camion(año, nom, paten, model);
                return v1;
            }
            else if (tipo == "bus")
            {
                Console.WriteLine("nombre del bus");
                nom = Console.ReadLine();
                Console.WriteLine("patente del bus");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del bus");
                model = Console.ReadLine();
                Console.WriteLine("año del bus");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Bus(año, nom, paten, model);
                return v1;
            }
            else if (tipo == "acuatico")
            {
                Console.WriteLine("nombre del vehiculo acuatico");
                nom = Console.ReadLine();
                Console.WriteLine("patente del vehiculo acuatico");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del vehiculo acuatico");
                model = Console.ReadLine();
                Console.WriteLine("año del vehiculo acuatico");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Acuatico(año, nom, paten, model);
                return v1;
            }
            else if (tipo == "auto")
            {
                Console.WriteLine("nombre del auto");
                nom = Console.ReadLine();
                Console.WriteLine("patente del auto");
                paten = Console.ReadLine();
                Console.WriteLine("modelo del auto");
                model = Console.ReadLine();
                Console.WriteLine("año del auto");
                año = Int32.Parse(Console.ReadLine());
                Console.WriteLine("tiene corrida de asiento extra (1)SI   (2)NO");
                int num = Int32.Parse(Console.ReadLine());
                bool a,b;
                if (num == 1) { a = true; }
                else { a = false; }
                Console.WriteLine("tiene un maletero grande (1)SI   (2)NO");
                int num1 = Int32.Parse(Console.ReadLine());
                if (num == 1) { b = true; }
                else { b = false; }
                Vehiculo v1 = new Auto(año, nom, paten, model, a, b);
                return v1;
            }
            else if (tipo == "moto")
            {
                Console.WriteLine("nombre de la moto");
                nom = Console.ReadLine();
                Console.WriteLine("patente de la moto");
                paten = Console.ReadLine();
                Console.WriteLine("modelo de la moto");
                model = Console.ReadLine();
                Console.WriteLine("año de la moto");
                año = Int32.Parse(Console.ReadLine());
                Vehiculo v1 = new Moto(año, nom, paten, model);
                return v1;
            }
            else
            {
                Console.WriteLine("tipo no es correcto");
                Vehiculo v = new Vehiculo(0,"","","");
                return v;
            }
        }
    }

}
