
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class GenteAsustada : DecoratorSector
    {

        //ESTADO QUE SE LE ASIGNA UN VALOR EN LA FABRICA CONCRETA DEL PATRON FACTORY METHOD
        private int cantidadPersonas;

        //CONSTRUCTOR DE LA CLASE, AL INSTANCIARLA PUEDE RECIBIR UN ISECTOR Y ESTE SE PASA POR EL COMANDO BASE AL ESTADO DE LA CLASE PADRE
        public GenteAsustada (ISector pSector, int personas) : base(pSector)
        {
            this.cantidadPersonas = personas;
        }


        //METODO DE ESCRITURA PARA ASIGNARLE UN VALOR AL ESTADO
        public void setCantidadPersonas(int pCantidad)
        {
            this.cantidadPersonas = pCantidad;
        }



       /* E.EL DECORADO “GENTE ASUSTADA” TENDRÁ UN PARÁMETRO CANTIDAD DE PERSONAS(ENTRE 0 Y 5) QUE RESTARÁ
          EL 75% AL VALOR DE AGUA RECIBIDO. ESTA RESTA SOLO LO HARÁ COMO MÁXIMO CANTIDAD DE PERSONAS VECES.*/
        public override void Mojar(double pAgua)
        {
            //OBTENEMOS EL 75% DEL PORCENTAJE DEL AGUA
            double porcentajeAgua = pAgua * 0.75;
            double resultadoFinal = 0;

            //REALIZAMOS LA RESTA LA CANTIDAD DE VECES SEGUN LAS CANTIDAD DE PERSONAS EN EL ESTADO
            for (int i = 0; i < this.cantidadPersonas; i++)
            {
                //SE RESTA LA CANTIDAD DE PERSONAS AL 75% DEL AGUA
                resultadoFinal = porcentajeAgua - cantidadPersonas;
            }            
            base.Mojar(resultadoFinal);
        }


    }
}
