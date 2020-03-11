using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class SectorSimple : DecoratorSector
    {
        public SectorSimple(ISector pSector): base(pSector) { }


        public override void Mojar(double pAgua)
        {
            base.Mojar(pAgua);
        }

    }
}
