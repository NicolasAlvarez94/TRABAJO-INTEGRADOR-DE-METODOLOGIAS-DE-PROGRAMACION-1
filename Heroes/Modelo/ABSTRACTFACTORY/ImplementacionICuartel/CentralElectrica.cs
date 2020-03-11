using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class CentralElectrica : ICuartel
    {
        private List<IVehiculo> vehiculos = new List<IVehiculo>();
        private List<IHerramienta> herramientas = new List<IHerramienta>();
        private List<IResponsable> responsables = new List<IResponsable>();
        private static int contador = 0;

        //PATRON SINGLETON
        private static CentralElectrica cuartel = null;

        private CentralElectrica() { }
      
        public static CentralElectrica getCuartelElectricista()
        {
            if (cuartel == null)            
                cuartel = new CentralElectrica();                
            
            return cuartel;
        }
        //*****************************************************************
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
            Electricista responsable = (Electricista) this.responsables[contador];
            IHerramienta herramienta = this.herramientas[contador];
            IVehiculo vehiculo = this.vehiculos[contador];

            responsable.setHerramienta(herramienta);
            responsable.setVehiculo(vehiculo);

            contador++;
            return responsable;
        }
    }
}
