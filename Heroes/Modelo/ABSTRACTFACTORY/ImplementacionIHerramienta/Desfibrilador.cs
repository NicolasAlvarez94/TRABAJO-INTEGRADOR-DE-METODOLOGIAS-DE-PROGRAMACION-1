using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Desfibrilador : IHerramienta
    {
        public void guardar()
        {
            Console.Write("GUARDEMOS EL DESFIBRILADOR, YA TODO ESTA EN ORDEN");
        }

        public void usar()
        {
            Console.Write("PREPARAR EL DESFIBRILADOR PARA REANIMARLO");
        }
    }
}
