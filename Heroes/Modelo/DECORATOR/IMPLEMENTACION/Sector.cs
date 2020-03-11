using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Sector : ISector
    {
        private double porcentajeAfectacionFuego;

        public Sector(double pPorcentaje)
        {
            this.porcentajeAfectacionFuego = pPorcentaje;
        }
  
        public Sector()
        {

        }


        public void setPorcentajeAfectacionFuego(double pPorcentaje)
        {
            this.porcentajeAfectacionFuego = pPorcentaje;
        }

        public double getPorcentajeAfectacionFuego()
        {
            return porcentajeAfectacionFuego;
        }

        public void Mojar(double pAgua)
        {
            this.porcentajeAfectacionFuego -= pAgua;
        }

        public bool EstaApagado()
        {
            if (this.porcentajeAfectacionFuego <= 0)
            {
                return true;
            }
            else { return false; }
        }



    }
}
