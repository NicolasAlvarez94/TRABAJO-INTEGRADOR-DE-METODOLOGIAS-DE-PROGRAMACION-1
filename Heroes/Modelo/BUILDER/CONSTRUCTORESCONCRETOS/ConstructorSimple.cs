using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ConstructorSimple : ConstructorSector
    {
        public override ISector ConstruirSector(int pAfectacionFuego)
        {
            ISector sector = new Sector(pAfectacionFuego);
            sector = FabricaDeDecorados.CrearDecorado(3,sector,0);
            return sector;
        }
    }
}
