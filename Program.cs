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
            List<string> name_vehiculos = new List<string> { "maquinaria", "camion", "bus", "acuatico", "auto", "moto" };

            


            while(true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
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
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("MENU \n (1) agregar sucursal\n (2) registrar cliente\n (3) arrendar vehiculo\n (4) agregar vehiculo a la sucursal\n (5) devolver vehiculo\n (6)salir ");
                opcion = Console.ReadLine();
                Console.Clear();
                Console.ResetColor();
                if (opcion=="1")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    List<Vehiculo> vehiculos = new List<Vehiculo>();
                    Console.WriteLine("Nombre sucursal:  ");
                    nom = Console.ReadLine();
                    Console.WriteLine("direccion sucursal:  ");
                    direc = Console.ReadLine();
                    Console.WriteLine("rut sucursal:  ");
                    rut = Int32.Parse(Console.ReadLine());
                    Sucursal s = new Sucursal(nom, direc, rut, vehiculos);
                    sucursales.Add(s);
                    Console.ResetColor();

                }
                else if (opcion == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
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
                    Console.ResetColor();
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
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                List<String> accesorios_comprados = new List<string>();
                                                Arriendo.Arrendar(s, vehi, c, sucursales, clientes, s.vehiculos, accesorios1);
                                                Arriendo arr = new Arriendo(s, vehi, c, accesorios_comprados);
                                                arriendos.Add(arr);
                                                s.vehiculos.Remove(vehi);
                                                Console.Beep();
                                                Console.WriteLine("Exito, arriendo creado");
                                                arr.Info(arr);
                                                Console.ResetColor();
                                              
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.Beep();
                                                Console.Beep();
                                                Console.WriteLine("error al ingresar los datos");
                                                Console.ResetColor();
                                                break;
                                            }
                                        }
                                        

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Beep();
                                        Console.Beep();
                                        Console.WriteLine("error al ingresar los datos");
                                        Console.ResetColor();
                                        break ;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Beep();
                                Console.Beep();
                                Console.WriteLine("rut no existente ");
                                Console.ResetColor();
                                break;
                            }
                        }
                    }
                }
                else if (opcion == "6")
                {
                    break;
                }
                else if (opcion == "4")
                {
                    Console.WriteLine("seleccione sucursal por id");
                    foreach  (Sucursal s in sucursales)
                    {
                        Console.WriteLine("nombre:" + s.nombre +" id: " + s.rut);
                    }
                    id = Int32.Parse(Console.ReadLine());
                    foreach (Sucursal s in sucursales)
                    {
                        if (id==s.rut)
                        {
                            s.Agregarvehiculo(s.Crearvehiculo());
                        }
                    }
                }
                else if (opcion == "5")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("que tipo de vehiculo quiere devolver?");
                    Console.WriteLine(name_vehiculos);
                    //lo devuelve por default a la primera sucursal de la lista
                    if (sucursales[0].devolvervehiculo().patente== "")
                    {
                        Console.WriteLine("no se puedo devolver vehiculo a la sucursal");

                    }
                    else
                    {
                        sucursales[0].vehiculos.Add(sucursales[0].devolvervehiculo());
                        Console.WriteLine("se a recibido tu vehiculo gracias por contratar este servicio");


                    }


                }

            }
           




        }
    }          
}


