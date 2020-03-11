using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class DecoratorSector : ISector
    {
        //ESTADO
        protected ISector sector;
      

        public DecoratorSector(ISector pSector)
        {
            this.sector = pSector;
        }


        //METODOS QUE DELEGAN AL FINAL LA RESPONSABILIDAD A LOS METODOS DE LA CLASE SECTOR
        public bool EstaApagado()
        {
            return sector.EstaApagado();
        }

        //METODOS CON MODIFICADOR VIRTUAL PARA QUE PUEDAN SER SOBREESCRITOS POR LAS CLASES DERIVADAS
        public virtual void Mojar(double pAgua)
        {
            sector.Mojar(pAgua);
        }
        public virtual double getPorcentajeAfectacionFuego()
        {
            return sector.getPorcentajeAfectacionFuego();
        }


    }
}
