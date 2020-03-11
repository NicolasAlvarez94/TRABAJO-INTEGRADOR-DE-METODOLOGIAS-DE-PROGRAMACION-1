using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class CompuestoManzana : IIluminable
    {
        //COMPUESTO ESTA CONFORMADO POR UNA LISTA DE IILUMINABLES (CALLES - ESQUINAS - PLAZA)

        private List<IIluminable> iluminables;

        public List<IIluminable> getIluminables()
        {
            return iluminables;
        }

               
        public CompuestoManzana()
        {
            this.iluminables = new List<IIluminable>();
        }


        public void Agregar (IIluminable pIluminable)
        {
            this.iluminables.Add(pIluminable);
        }

    
        public void RevisarYCambiarLamparasQuemadas()
        {
            foreach (IIluminable item in this.iluminables)
            {
                item.RevisarYCambiarLamparasQuemadas();
            }
            
        }
    }
}
