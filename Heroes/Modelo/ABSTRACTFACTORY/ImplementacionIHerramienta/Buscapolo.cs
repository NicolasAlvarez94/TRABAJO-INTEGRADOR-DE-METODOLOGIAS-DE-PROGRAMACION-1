using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Buscapolo : IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("GUARDANDO EL BUSCAPOLO");
        }

        public void usar()
        {
            Console.WriteLine("COMPROBANDO TENSION");
        }
    }
}
