using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDePolicias : IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return Comisaria.getCuartelPolicia();
        }

        public IResponsable crearHeroe()
        {
            return new Policia();
        }

        public IHerramienta crearHerramienta()
        {
            return new Pistola();
        }

        public IVehiculo crearVehiculo()
        {
            return new Patrullero();
        }
    }
}
