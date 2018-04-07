using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoPc
{
    public class DispositivoEntrada
    {
        protected string tipoEntrada;
        protected string marca;

        public DispositivoEntrada(string tipoEntrada, string marca)
        {
            this.tipoEntrada = tipoEntrada;
            this.marca = marca;
        }

        public string GetTipoEntrada() { return tipoEntrada; }
        public void SetTipoEntrada(string tipoEntrada) { this.tipoEntrada = tipoEntrada; }

        public string GetMarca() { return marca; }
        public void SetMarca(string marca) { this.marca = marca; }

        public override string ToString()
        {
            return ",  es de tipo " + tipoEntrada + " y es de la marca " + marca + ".";
        }
    }
}
