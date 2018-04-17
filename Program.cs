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
            string nom, opcion, op;
            string direc;
            int rut;
            int id;
            List<Arriendo> arriendos = new List<Arriendo>();
            List<Sucursal> sucursales = new List<Sucursal>();
            List<Cliente> clientes = new List<Cliente>();
            List<Accesorios> accesorios1 = new List<Accesorios>();
            List<string> name_accesorios = new List<string> { "radios con bluetooth", "GPS, ruedas extra de repuesto", "cortinas para ventanas", "sillas para infantes" };
            foreach (string name in name_accesorios)
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 20);
                Accesorios acc = new Accesorios(name, value);
                accesorios1.Add(acc);
            }
            


            while(true)
            {
                if (sucursales.Count ==0) 
                {
                    List<Vehiculo> vehiculos1 = new List<Vehiculo>();
                    Console.WriteLine("NO existe  sucursal, agregue 1 ");
                    Console.WriteLine("Nombre sucursal:  ");
                    nom= Console.ReadLine();
                    Console.WriteLine("direccion sucursal:  ");
                    direc = Console.ReadLine();
                    Console.WriteLine("rut sucursal:  ");
                    rut = Int32.Parse(Console.ReadLine());
                    Sucursal s = new Sucursal(nom, direc, rut, vehiculos1);
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
                    Sucursal s = new Sucursal(nom, direc, rut, vehiculos);
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
                        Persona p = new Persona(true, nom, id);
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
                        
                        Console.WriteLine("rut de persona o emepresa");
                        rut = Int32.Parse(Console.ReadLine());
                        
                        foreach (Cliente c in clientes)
                        {
                            if (c.id==rut)
                            {
                                Console.WriteLine("ingrese direccion sucursal:");
                                direc = Console.ReadLine();
                                foreach (Sucursal s in sucursales)
                                {
                                    if (direc==s.direccion)
                                    {
                                        Console.WriteLine("ingrese vehiculo que quiera arrendar");
                                        string v;
                                        v = Console.ReadLine();
                                        Console.WriteLine("ingrese su patente");
                                        string patente;
                                        patente = Console.ReadLine();
                                        foreach (Vehiculo vehi in s.vehiculos)
                                        {
                                            if (vehi.patente==patente)
                                            {
                                                List<String> accesorios_comprados = new List<string>();
                                                Arriendo.Arrendar(s, vehi, c, sucursales, clientes, s.vehiculos, accesorios1);
                                                Arriendo arr = new Arriendo(s, vehi, c, accesorios_comprados);
                                                arriendos.Add(arr);
                                            }
                                        }
                                        

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("rut no existente ");
                                break;
                            }
                        }
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


