using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ConstructorFavorable : ConstructorSector
    {
        private int intLluvia;

        public void setIntLluvia(int lluvia)
        {
            this.intLluvia = lluvia;
        }

        public override ISector ConstruirSector(int pAfectacionFuego)
        {
            ISector sector = new Sector(pAfectacionFuego);            
            sector = FabricaDeDecorados.CrearDecorado(4,sector,this.intLluvia);
            return sector;
        }
    }
}
