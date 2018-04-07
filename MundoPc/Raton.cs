using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class Raton : DispositivoEntrada
    {
        private int idRaton;
        private static int contadorRatones;

        public Raton() : base(null,null) { idRaton = ++contadorRatones; }
        public Raton(string tipoEntrada, string marca) 
            : base(tipoEntrada, marca){ idRaton = ++contadorRatones; }

        public override string ToString()
        {
            return "El raton #" + idRaton +  base.ToString();
        }
    }
}
