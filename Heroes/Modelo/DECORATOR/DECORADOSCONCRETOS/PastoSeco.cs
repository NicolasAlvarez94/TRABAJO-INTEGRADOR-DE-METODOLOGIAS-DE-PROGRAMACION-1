using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class PastoSeco : DecoratorSector
    {
        
        //CONSTRUCTOR DE LA CLASE, AL INSTANCIARLA PUEDE RECIBIR UN ISECTOR Y ESTE SE PASA POR EL COMANDO BASE AL ESTADO DE LA CLASE PADRE
        public PastoSeco(ISector pSector) : base(pSector) { }


        //EL DECORADO “PASTO SECO” DIVIDE POR DOS EL VALOR DEL CAUDAL DE AGUA. 
        public override void Mojar(double pAgua)
        {
            double mitadCaudalAgua = pAgua / 2;
            base.Mojar(mitadCaudalAgua);
        }







    }
}
