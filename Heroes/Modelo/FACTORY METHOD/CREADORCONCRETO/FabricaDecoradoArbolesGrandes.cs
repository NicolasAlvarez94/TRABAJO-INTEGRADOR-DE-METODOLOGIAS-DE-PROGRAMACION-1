using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDecoradoArbolesGrandes : FabricaDeDecorados
    {
        //IMPLEMENTACION DEL METODO DE LA CLASE PADRE QUE CREA LA INSTANCIA CONCRETA DE UN DECORADO
        public override ISector CrearDecorado(ISector pSector)
        {
            pSector = new ArbolesGrandes(pSector);
            return pSector;
        }

    }
}
