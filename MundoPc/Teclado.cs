using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class Teclado : DispositivoEntrada
    {
        private int idTeclado;
        private static int contadorTeclado;

        public Teclado() : base(null, null) { idTeclado = ++contadorTeclado; } 
        public Teclado(string tipoEntrada, string marca) 
            : base(tipoEntrada, marca) { idTeclado = ++contadorTeclado; }

        public override string ToString()
        {
            return "El teclado #" + idTeclado + base.ToString();
        }
    }
}
