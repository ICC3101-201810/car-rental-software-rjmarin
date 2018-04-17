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
        List<String> accesorios_comprados;


        public Arriendo(Sucursal miSucursal, Vehiculo miVehiculo, Cliente Micliente, List<String> miacc_comprados)
        {
            sucursal = miSucursal;
            vehiculo = miVehiculo;
            cliente = Micliente;
            accesorios_comprados = miacc_comprados;

            
            
        }

        public static void Arrendar(Sucursal sucursal, Vehiculo vehiculo, Cliente cliente,List<Sucursal> sucursales,List<Cliente> clientes,List<Vehiculo> vehiculos,List<Accesorios>accesorios)
        {
            List<String> accesorios_comprados = new List<string>();
            foreach (Sucursal s in sucursales)
            {
                if (s.nombre == sucursal.nombre)
                {
                    foreach (Cliente c in clientes)
                    {
                        if (c.id == cliente.id)
                        {
                            foreach (Vehiculo v in sucursal.vehiculos)
                            {
                                if (v.nombre==vehiculo.nombre && v.año==vehiculo.año)
                                {
                                    int opc;
                                    Console.WriteLine("desea agregar accesorios?\n (1) si\n (2) no\n");
                                    opc= Int32.Parse(Console.ReadLine());
                                    if (opc==1)
                                    {
                                        Console.WriteLine("accesorios que pueda elegir");
                                        foreach (Accesorios a in accesorios)
                                        {
                                            Console.WriteLine(a.nombre + "\n");
                                        }
                                        int pp;
                                        Console.WriteLine("cuantos accesorios quieres?");
                                        pp = Int32.Parse(Console.ReadLine());
                                        for (int i = 0; i < pp; i++)
                                        {
                                             string accesorioacomprar;
                                             Console.WriteLine("escriba accesorio que quiere comprar");
                                             accesorioacomprar= Console.ReadLine();
                                             foreach (Accesorios a in accesorios)
                                             {
                                                if (a.nombre==accesorioacomprar && a.stock!=0)
                                                {
                                                    a.stock--;
                                                    Console.WriteLine("accesiorio agregado a la compra");
                                                    accesorios_comprados.Add(accesorioacomprar);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("no hay stock");
                                                }
                                             }

                                            
                               
                                        }
                                        
                                    }


                                }
                            }

                        }

                    }
                }

            }


        }
    }
}
