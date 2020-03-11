using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Hospital : ICuartel
    {
        private List<IVehiculo> vehiculos = new List<IVehiculo>();
        private List<IHerramienta> herramientas = new List<IHerramienta>();
        private List<IResponsable> responsables = new List<IResponsable>();
        private static int contador = 0;

        private static Hospital hospital = null;

        private Hospital() {}

        public static Hospital getHospital()
        {
            if (hospital == null)
                hospital = new Hospital();
            return hospital;
        }

        public void agregarHerramienta(IHerramienta pHerramienta)
        {
            this.herramientas.Add(pHerramienta);
        }

        public void agregarPersonal(IResponsable pResponsable)
        {
            this.responsables.Add(pResponsable);
        }

        public void agregarVehiculo(IVehiculo pVehiculo)
        {
            this.vehiculos.Add(pVehiculo);
        }

        public IResponsable getPersonal()
        {
            Medico responsable = (Medico)this.responsables[contador];
            IHerramienta herramienta = this.herramientas[contador];
            IVehiculo vehiculo = this.vehiculos[contador];

            responsable.setHerramienta(herramienta);
            responsable.setVehiculo(vehiculo);

            contador++;

            return responsable;
        }        
           
        

    }
}
