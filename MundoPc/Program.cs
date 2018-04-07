using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor m1 = new Monitor("Logitech", 14.5);
            Monitor m2 = new Monitor("RCA", 32.0);
            Teclado t1 = new Teclado("USB", "Imexx");           
            Teclado t2 = new Teclado("USB", "Logitech");
            Raton r1 = new Raton("PS/2", "Polaroid");

            Computadora c1 = new Computadora("Asus", m1, t1, r1);
            Computadora c2 = new Computadora("Dell", m2, t2, r1);

            Orden orden1 = new Orden();
            Orden orden2 = new Orden();

            orden1.AgregarComputadora(c1);
            orden2.AgregarComputadora(c2);

            orden1.MostrarOrden();

            Console.Write("\n======================================================================\n");

            orden2.MostrarOrden();
            Console.ReadKey();
        }
    }
}
