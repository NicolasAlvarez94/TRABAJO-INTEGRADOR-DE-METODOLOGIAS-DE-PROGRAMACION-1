using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DiaVentoso : DecoratorSector
    {
        //ESTADO QUE SE LE ASIGNA UN VALOR EN LA FABRICA CONCRETA DEL PATRON FACTORY METHOD
        private int velocidadViento; 
        
        //CONSTRUCTOR QUE PASA POR COMANDO BASE EL SECTOR AL ESTADO DE LA CLASE PADRE
        public DiaVentoso (ISector pSector, int viento): base(pSector)
        {
            this.velocidadViento = viento;
        }

        //METODO DE ESCRITURA PARA ASIGNARLE UN VALOR AL ESTADO
        public void setVelocidadViento(int pViento)
        {
            this.velocidadViento = pViento;
        }


        /*D.EL DECORADO “DÍA VENTOSO” TENDRÁ UN ESTADO VELOCIDAD DEL VIENTO(ENTRE 80 Y 250)
          Y LE RESTA AL VALOR DE AGUA RECIBIDO EL RESULTADO DE(e^(VELOCIDAD / 100)). */

        public override void Mojar(double pAgua)
        {
            double viento = Math.Exp(velocidadViento/100);
            double resultadoFinal = pAgua - viento;
            base.Mojar(resultadoFinal);
        }



    }
}
