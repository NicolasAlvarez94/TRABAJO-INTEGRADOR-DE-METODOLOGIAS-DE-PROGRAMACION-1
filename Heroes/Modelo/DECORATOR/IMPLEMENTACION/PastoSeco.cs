using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class PastoSeco : DecoratorSector
    {
        
        public PastoSeco(ISector pSector):base(pSector)
        {
            this.sector = pSector;
           
        }


        public override void Mojar(double pAgua)
        {
            double mitadCaudalAgua = pAgua / 2;
            base.Mojar(mitadCaudalAgua);
        }

        public double getPorcentajeAfectacionFuego()
        {
            return base.sector.getPorcentajeAfectacionFuego();
        }





    }
}
