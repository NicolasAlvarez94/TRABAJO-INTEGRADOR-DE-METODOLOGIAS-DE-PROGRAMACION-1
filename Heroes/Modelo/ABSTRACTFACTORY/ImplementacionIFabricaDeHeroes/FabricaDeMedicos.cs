using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class FabricaDeMedicos : IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return Hospital.getHospital();
        }

        public IResponsable crearHeroe()
        {
            return new Medico();
        }

        public IHerramienta crearHerramienta()
        {
            return new Desfibrilador();
        }

        public IVehiculo crearVehiculo()
        {
            return new Ambulancia();
        }
    }
}
