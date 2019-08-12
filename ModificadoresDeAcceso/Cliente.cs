using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cliente
    {
        public string Nombre { get; set; } //autoproperty
        public DateTime FechaDdeNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        private string _curp;
        public string Curp
        {
            get
            {
                return _curp;
            }
            set
            {
                if (value.Length==18)
                {
                    _curp = value;
                } else
                {
                    throw new Exception("no es de 18 caracteres");
                }
                
            }
        }




    }
}
