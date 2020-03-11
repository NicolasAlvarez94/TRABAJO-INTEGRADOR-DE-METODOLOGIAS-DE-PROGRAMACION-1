using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDecoradoDiaVentoso : FabricaDeDecorados
    {
        //ESTADO QUE SE LE ASIGNA VALOR EN EL CONSTRUCTOR Y ES SETEADO A LA INSTANCIA DEL DECORADO DE DIAVENTOSO
        private int intViento;
        public FabricaDecoradoDiaVentoso(int pViento)
        {
            this.intViento = pViento;
        }

        //IMPLEMENTACION DEL METODO DE LA CLASE PADRE QUE CREA LA INSTANCIA CONCRETA DE UN DECORADO
        public override ISector CrearDecorado(ISector pSector)
        {
            pSector = new DiaVentoso(pSector, this.intViento);
            return pSector;
        }
    }
}
