using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class OrdenAvisarComisariaYPedirRefuerzos : Iorden
    {
        public void Ejecutar()
        {
            Console.WriteLine("NECESITO REFUERZOS");
        }
    }
}
