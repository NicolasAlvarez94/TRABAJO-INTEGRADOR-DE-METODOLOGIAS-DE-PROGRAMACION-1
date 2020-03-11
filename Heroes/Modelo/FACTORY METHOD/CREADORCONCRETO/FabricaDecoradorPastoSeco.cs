using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDecoradorPastoSeco : FabricaDeDecorados
    {
        
        //IMPLEMENTACION DEL METODO DE LA CLASE PADRE QUE CREA LA INSTANCIA CONCRETA DE UN DECORADO
        public override ISector CrearDecorado(ISector pSector)
        {
            pSector = new PastoSeco(pSector);
            return pSector;
        }
    }
}
