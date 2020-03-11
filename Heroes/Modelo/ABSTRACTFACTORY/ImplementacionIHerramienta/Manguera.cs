using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Manguera : IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("GUARDANDO LA MANGUERA");
        }

        public void usar()
        {
            Console.WriteLine("APAGANDO INCENDIO CON MANGUERA");
        }
    }
}
