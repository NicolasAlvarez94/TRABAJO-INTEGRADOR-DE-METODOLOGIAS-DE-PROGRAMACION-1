using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDeElectricistas : IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return CentralElectrica.getCuartelElectricista();
        }

        public IResponsable crearHeroe()
        {
            return new Electricista();
        }

        public IHerramienta crearHerramienta()
        {
            return new Buscapolo();
        }

        public IVehiculo crearVehiculo()
        {
            return new Camioneta();
        }
    }
}
