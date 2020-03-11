using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ConstructorDesfaborable : ConstructorSector
    {
        private int temperatura;
        private int viento;
        private int cantidadPersonas;

        public void setCantidadPersonas(int personas)
        {
            this.cantidadPersonas = personas;
        }

        public void setViento (int viento)
        {
            this.viento = viento;
        }

        public void setTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }

        public override ISector ConstruirSector(int pAfectacionFuego)
        {
            ISector sector = new Sector (pAfectacionFuego);
            sector = FabricaDeDecorados.CrearDecorado(1,sector,0);
            sector = FabricaDeDecorados.CrearDecorado(2,sector,0);
            sector = FabricaDeDecorados.CrearDecorado(7, sector, this.temperatura);
            sector = FabricaDeDecorados.CrearDecorado(6, sector, this.cantidadPersonas);
            sector = FabricaDeDecorados.CrearDecorado(5, sector, this.viento);
            return sector;            
        }
    }
}
