using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaSectorSimple : FabricaDeDecorados
    {
        public override ISector CrearDecorado(ISector pSector)
        {            
            return new SectorSimple(pSector);
        }
    }
}
