using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Sector: ISector
    {                   

        //PORCENTAJE DE AFECTACION
        protected double porcentajeAfectacionFuego;

        //******************************************************************

        //CONSTRUCTOR QUE INICIALIZA EL ESTADO DEL PORCENTAJE DE AFECTACION
        public Sector(double pPorcentaje)
        {
            this.porcentajeAfectacionFuego = pPorcentaje;
        }

         public Sector() { }
         
         
        //******************************************************************

        //METODOS DE ACCESOS
        public void setPorcentajeAfectacionFuego(double pPorcentaje)
        {
            this.porcentajeAfectacionFuego = pPorcentaje;
        }

        public virtual double getPorcentajeAfectacionFuego()
        {
            return porcentajeAfectacionFuego;
        }

        //******************************************************************

        //METODOS
        public void Mojar(double pAgua)
        {
            this.porcentajeAfectacionFuego -= pAgua;
        }

        //METODO EN COMUN PARA TODOS LOS SECTORES PARA EVALUAR SI ESTAN APAGADOS
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
