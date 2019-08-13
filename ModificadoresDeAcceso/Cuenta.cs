using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public Cliente Propietario { get; set; }
        private string _identificador;
        public string Identificador
        {
            get
            {
                return _identificador;
            }
            set
            {
                if (value.Length >= 10 && value.Length <= 14)
                {
                    _identificador = value;

                }
                else
                {
                    throw new Exception("no tiene la cantidad correcta de caracteres");
                }
            }
        }
        public float Saldo { get; set; }
    }
}
