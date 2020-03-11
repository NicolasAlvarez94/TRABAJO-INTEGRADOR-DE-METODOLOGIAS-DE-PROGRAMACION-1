using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class OrdenPerseguirHastaArrestar : Iorden
    {
        public void Ejecutar()
        {
            Console.WriteLine("DETENGASE");
        }
    }
}
