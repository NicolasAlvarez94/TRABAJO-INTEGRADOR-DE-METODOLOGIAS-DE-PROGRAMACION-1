using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDecoradorMuchoCalor : FabricaDeDecorados
    {
        //ESTADO QUE SE LE ASIGNA VALOR EN EL CONSTRUCTOR Y ES SETEADO A LA INSTANCIA DEL DECORADO DE MUCHOCALOR
        private int intTemperatura;

        public FabricaDecoradorMuchoCalor(int pTemperatura)
        {
            this.intTemperatura = pTemperatura;
        }

        //IMPLEMENTACION DEL METODO DE LA CLASE PADRE QUE CREA LA INSTANCIA CONCRETA DE UN DECORADO
        public override ISector CrearDecorado(ISector pSector)
        {
            pSector = new MuchoCalor(pSector, this.intTemperatura);
            return pSector;
        }
    }
}
