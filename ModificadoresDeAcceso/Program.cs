using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();

            cliente.Nombre = "Emiliano";
            cliente.Telefono = "1234";

            Console.WriteLine("nombre:" + cliente.Nombre);
            Console.WriteLine("telefono:" + cliente.Telefono);
            try
            {
                cliente.Curp = "1234567891234567891";
                Console.WriteLine("curp:" + cliente.Curp);
            }
            catch (Exception e)
            {
                Console.WriteLine("la curp debe ser de 18 caracteres");
            }

            Cuenta cuenta
                = new Cuenta();
         // cuenta. Propietario= 

            try
            {
                cuenta.Identificador = "12346";
                Console.WriteLine("identificador:" + cuenta.Identificador);
            }
            catch (Exception a)
            {
                Console.WriteLine("el identificador no es el correcto");
            }


            Console.Read();
        }
    }
}
