using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ArbolesGrandes : DecoratorSector
    {
        //CONSTRUCTOR DE LA CLASE, AL INSTANCIARLA PUEDE RECIBIR UN ISECTOR Y ESTE SE PASA POR EL COMANDO BASE AL ESTADO DE LA CLASE PADRE
        public ArbolesGrandes(ISector pSector): base(pSector) { }



        //B. EL DECORADO “ÁRBOLES GRANDES” RESTA UN 25% AL VALOR DEL CAUDAL DE AGUA. 
        public override void Mojar(double pAgua)
        {
            double restoDePorcentaje = pAgua * 0.25;
            double porcentajeFinal = pAgua - restoDePorcentaje;
            base.Mojar(porcentajeFinal);
        }




    }
}
