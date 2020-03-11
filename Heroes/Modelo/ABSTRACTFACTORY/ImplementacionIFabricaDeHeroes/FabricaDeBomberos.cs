using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDeBomberos : IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return CuartelDeBomberos.getCuartelBombero();
        }

        public IResponsable crearHeroe()
        {
            return new Bombero();
        }

        public IHerramienta crearHerramienta()
        {
            return new Manguera();
        }

        public IVehiculo crearVehiculo()
        {
            return new Autobomba();
        }
    }
}
