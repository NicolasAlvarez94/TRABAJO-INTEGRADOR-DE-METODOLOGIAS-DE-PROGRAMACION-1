using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface ICuartel
    {
        void agregarVehiculo(IVehiculo pVehiculo);
        void agregarPersonal(IResponsable pResponsable);
        void agregarHerramienta(IHerramienta pHerramienta);
        IResponsable getPersonal();
    }
}
