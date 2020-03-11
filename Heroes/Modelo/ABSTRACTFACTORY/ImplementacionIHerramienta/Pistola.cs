using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Pistola : IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("GUARDANDO LA PISTOLA");
        }

        public void usar()
        {
            Console.WriteLine("DISPARANDO A DISCRECION");
        }
    }
}
