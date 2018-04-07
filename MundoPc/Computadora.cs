using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class Computadora
    {
        private int idComputadora;
        private string nombre;
        private static int contadorComputadora;
        private Monitor monitor;
        private Teclado teclado;
        private Raton raton;

        
        private Computadora(){ idComputadora = ++contadorComputadora;  }

        public Computadora(string nombre, Monitor monitor, Teclado teclado, Raton raton) 
            : this()
        {
            this.nombre = nombre;
            this.monitor = monitor;
            this.teclado = teclado;
            this.raton = raton;
        }

        public string GetNombre() { return nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }

        public Monitor GetMonitor() { return monitor; }
        public void SetMonitor(Monitor monitor){ this.monitor = monitor; }

        public Teclado GetTeclado() { return teclado; }
        public void SetTeclado(Teclado teclado){ this.teclado = teclado; }

        public Raton GetRaton() { return raton; }
        public void SetRaton(Raton raton){ this.raton = raton; }

        public override string ToString()
        {
            return "La computadora #" + idComputadora + " es una " + nombre + " y tiene los siguientes componentes:\n\n"
                    + monitor + "\n" + teclado + "\n" + raton; 
        }
    }
}
