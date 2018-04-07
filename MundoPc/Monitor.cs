using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class Monitor
    {
        private int idMonitor;
        private string marca;
        private double tamanio;
        private static int contadorMonitor;

        private Monitor(){ idMonitor = ++contadorMonitor;  }

        public Monitor(string marca, double tamanio) 
            : this()
        {
            this.marca = marca;
            this.tamanio = tamanio;
        }

        public string GetMarca() { return marca; }
        public void SetMarca(string marca) { this.marca = marca; }

        public double GetTamanio() { return tamanio; }
        public void SetTamanio(double tamanio) { this.tamanio = tamanio; }

        public override string ToString()
        {
            return "El Monitor #" + idMonitor + " es de la marca " + marca + " y tiene un tamaño de " + tamanio + "plg.";
        }
    }
}
