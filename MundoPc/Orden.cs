using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class Orden
    {
        private int idOrden;
        private Computadora [] computadoras;
        private static int contadorOrdenes;
        private int contadorComputadoras;
        private const int maxComputadoras = 10;

        public Orden()
        {
            idOrden = ++contadorOrdenes;
            computadoras = new Computadora[maxComputadoras];
        }

        public void AgregarComputadora(Computadora computadora)
        {
            if (contadorComputadoras < maxComputadoras)
                computadoras[contadorComputadoras++] = computadora;
            else
                Console.WriteLine("Ha superado el máximo de computadoras : {0}", maxComputadoras);

        }

        public void MostrarOrden()
        {
            Console.WriteLine("Orden #" + idOrden);
            for (int i = 0; i < contadorComputadoras; i++)
                Console.WriteLine(computadoras[i]);
        }
    }
}
