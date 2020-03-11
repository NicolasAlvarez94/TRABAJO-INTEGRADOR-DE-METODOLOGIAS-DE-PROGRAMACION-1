using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Comisaria : ICuartel
    {
        private List<IVehiculo> vehiculos = new List<IVehiculo>();
        private List<IHerramienta> herramientas = new List<IHerramienta>();
        private List<IResponsable> responsables = new List<IResponsable>();

        private static int contador = 0;

        //PARA PATRON SINGLETON
        private static Comisaria comisaria = null;
        private Comisaria() {}

        public static Comisaria getCuartelPolicia()
        {
            if (comisaria == null)
                comisaria = new Comisaria();
            return comisaria;
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
            Policia responsable = (Policia)this.responsables[contador];
            IHerramienta herramienta = this.herramientas[contador];
            IVehiculo vehiculo = this.vehiculos[contador];

            responsable.setHerramienta(herramienta);
            responsable.setVehiculo(vehiculo);

            contador++;

            return responsable;
        }
    }
}
