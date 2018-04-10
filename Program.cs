using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string nom,opcion,op;
            string direc;
            int rut,id;

            List<Sucursal> sucursales = new List<Sucursal>();
            List<Cliente> clientes = new List<Cliente>();
            while (true)
            {
                if (sucursales.Count ==0) 
                {
                    List<Vehiculo> vehiculos1 = new List<Vehiculo>();
                    Console.WriteLine("NO existe  sucursal, agregue 1 ");
                    Console.WriteLine("Nombre sucursal:  ");
                    nom= Console.ReadLine();
                    Console.WriteLine("Nombre sucursal:  ");
                    direc = Console.ReadLine();
                    Console.WriteLine("Nombre sucursal:  ");
                    rut = Int32.Parse(Console.ReadLine());
                    Sucursal s = new Sucursal(nom, direc, rut,vehiculos1);
                    sucursales.Add(s);
                }

                Console.WriteLine("MENU \n (1) agregar sucursal\n (2) registrar cliente\n (3) arrendar vehiculo\n (4) salir ");
                opcion = Console.ReadLine();
                if (opcion=="1")
                {
                    List<Vehiculo> vehiculos = new List<Vehiculo>();
                    Console.WriteLine("NO existe  sucursal, agregue 1 ");
                    Console.WriteLine("Nombre sucursal:  ");
                    nom = Console.ReadLine();
                    Console.WriteLine("direccion sucursal:  ");
                    direc = Console.ReadLine();
                    Console.WriteLine("rut sucursal:  ");
                    rut = Int32.Parse(Console.ReadLine());
                    Sucursal s = new Sucursal(nom, direc, rut,vehiculos);
                    sucursales.Add(s);
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("PRESIONE\n (1) persona\n (2) Empresa ");
                    op = Console.ReadLine();
                    if (op=="1")
                    {
                        Console.WriteLine("Nombre persona:  ");
                        nom = Console.ReadLine();
                        Console.WriteLine("id de la persona:  ");
                        id = Int32.Parse(Console.ReadLine());
                        Persona p = new Persona(true,nom, id);
                        clientes.Add(p);

                    }
                    else if (op == "2")
                    {
                        Console.WriteLine("Nombre de la empresa:  ");
                        nom = Console.ReadLine();
                        Console.WriteLine("id de la emperesa:  ");
                        id = Int32.Parse(Console.ReadLine());
                        Empresa p = new Empresa(true, nom, id);
                        clientes.Add(p);

                    }
                }
                else if (opcion == "3")
                {
                    if(clientes.Count== 0)
                    {
                        Console.WriteLine("no existe cliente");
                        continue;
                    }
                    else
                    {
                            
                    }
                }
                else if (opcion == "4")
                {
                    break;
                }

            }
           




        }
    }
}
