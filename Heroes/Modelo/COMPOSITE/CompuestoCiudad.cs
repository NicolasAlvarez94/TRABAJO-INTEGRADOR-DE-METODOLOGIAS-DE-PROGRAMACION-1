using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class CompuestoCiudad : IIluminable
    {
        private List<IIluminable> manzanas;


        public CompuestoCiudad()
        {
            this.manzanas = new List<IIluminable>();
        }


        public void Agregar(CompuestoManzana pIluminable)
        {
            this.manzanas.Add(pIluminable);
        }


        public void RevisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("REVISANDO LAS LAMPARAS DE LAS MANZANAS DE LA CIUDAD");
            Console.WriteLine();

            foreach (CompuestoManzana manzana in this.manzanas)
            {
                foreach(IIluminable iluminable in manzana.getIluminables())
                {
                    iluminable.RevisarYCambiarLamparasQuemadas();
                }
                Console.WriteLine();
            }
        }


    }
}
