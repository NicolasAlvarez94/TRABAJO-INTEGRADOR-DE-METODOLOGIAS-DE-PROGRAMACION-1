using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DiaLluvioso : DecoratorSector
    {
        //ESTADO QUE SE LE ASIGNA UN VALOR EN LA FABRICA CONCRETA DEL PATRON FACTORY METHOD

        private int intensidadLluvia;

        //CONSTRUCTOR DE LA CLASE, AL INSTANCIARLA PUEDE RECIBIR UN ISECTOR Y ESTE SE PASA POR EL COMANDO BASE AL ESTADO DE LA CLASE PADRE
        public DiaLluvioso (ISector pSector, int lluvia) : base(pSector)
        {
            this.intensidadLluvia = lluvia;
        }


        //METODO DE ESCRITURA PARA ASIGNARLE UN VALOR AL ESTADO
        public void setIntensidadLluvia(int pDato)
        {
            this.intensidadLluvia = pDato;
        }


        //F. EL DECORADO “DÍA LLUVIOSO” TENDRÁ UN PARÁMETRO INTENSIDAD DE LLUVIA (ENTRE 1 Y 500) QUE SE SUMARÁ AL CAUDAL RECIBIDO. 

        public override void Mojar(double pAgua)
        {
            double resultadoFinal = pAgua + this.intensidadLluvia;
            base.Mojar(resultadoFinal);
        }

  
    }
}
