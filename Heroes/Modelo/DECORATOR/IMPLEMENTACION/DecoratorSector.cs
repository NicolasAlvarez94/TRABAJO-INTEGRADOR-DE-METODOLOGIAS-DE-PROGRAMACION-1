using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class DecoratorSector : ISector
    {

        protected ISector sector;

        public DecoratorSector(ISector pSector)
        {
            this.sector = pSector;
        }



        public virtual bool EstaApagado()
        {
            return sector.EstaApagado();
        }

   

        public virtual void Mojar(double pAgua)
        {
            sector.Mojar(pAgua);
        }

        public double getPorcentajeAfectacionFuego()
        {
            return sector.getPorcentajeAfectacionFuego();
        }
    }
}
