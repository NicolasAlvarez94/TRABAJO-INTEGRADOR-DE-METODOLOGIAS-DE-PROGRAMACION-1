using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDecoradoDiaLLuvioso : FabricaDeDecorados
    {
        //ESTADO QUE SE LE ASIGNA VALOR EN EL CONSTRUCTOR Y ES SETEADO A LA INSTANCIA DEL DECORADO DE DIALLUVIOSO
        private int intLluvia;

        public FabricaDecoradoDiaLLuvioso(int pLluvia)
        {
            this.intLluvia = pLluvia;
        }

        //IMPLEMENTACION DEL METODO DE LA CLASE PADRE QUE CREA LA INSTANCIA CONCRETA DE UN DECORADO
        public override ISector CrearDecorado(ISector pSector)
        {
            pSector = new DiaLluvioso(pSector, this.intLluvia);
            return pSector;
        }
    }
}
