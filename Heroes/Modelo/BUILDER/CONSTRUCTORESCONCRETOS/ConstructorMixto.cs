using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ConstructorMixto : ConstructorSector
    {
        private int lluvia;

        public void setLluvia(int lluvia)
        {
            this.lluvia = lluvia;
        }
        public override ISector ConstruirSector(int pAfectacionFuego)
        {
            ISector sector = new Sector(pAfectacionFuego);            
            sector = FabricaDeDecorados.CrearDecorado(1, sector,0);
            sector = FabricaDeDecorados.CrearDecorado(2, sector,0);
            sector = FabricaDeDecorados.CrearDecorado(4, sector, this.lluvia);
            return sector;
        }

    }
}
