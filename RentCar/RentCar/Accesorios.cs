using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Accesorios
    {
        public string nombre;
        public int stock;

        public Accesorios(string miNombre, int miStock)
        {
            nombre = miNombre;
            stock = miStock;

        }

        public void Sacarac( List<Accesorios> accesorios,Accesorios acc)
        {
            foreach (Accesorios a in accesorios)
            {
                if (a.nombre==acc.nombre && a.stock!=0)
                {
                    a.stock--;
                }
                else
                {
                    Console.WriteLine("no hay estock de {0}",a.nombre);

                }
            }
        }
    }
}
