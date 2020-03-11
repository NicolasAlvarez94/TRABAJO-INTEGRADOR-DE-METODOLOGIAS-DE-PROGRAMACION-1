using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class MuchoCalor : DecoratorSector
    {
        //ESTADO QUE SE LE ASIGNA UN VALOR EN LA FABRICA CONCRETA DEL PATRON FACTORY METHOD

        private int temperatura;

        //CONSTRUCTOR DE LA CLASE, AL INSTANCIARLA PUEDE RECIBIR UN ISECTOR Y ESTE SE PASA POR EL COMANDO BASE AL ESTADO DE LA CLASE PADRE
        public MuchoCalor(ISector pSector, int temperatura) : base(pSector)
        {
            this.temperatura = temperatura;
        }


        //METODO DE ESCRITURA PARA ASIGNARLE UN VALOR AL ESTADO
        public void setTemperatura (int pTemperatura)
        {
            this.temperatura = pTemperatura;
        }


        /*C.EL DECORADO “DÍA DE MUCHO CALOR” TENDRÁ UN PARÁMETRO TEMPERATURA (ENTRE 30 Y 45)
            Y LE RESTA AL VALOR DE AGUA RECIBIDO EL RESULTADO DE (0.1 * TEMPERATURA). */
        public override void Mojar(double pAgua)
        {
            double porcentajeTemperatura = this.temperatura * 0.1;
            double resultado = pAgua - porcentajeTemperatura;
            base.Mojar(resultado);
        }





    }
}
