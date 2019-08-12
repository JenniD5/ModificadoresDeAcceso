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
           
            Console.Read();
        }
    }
}
