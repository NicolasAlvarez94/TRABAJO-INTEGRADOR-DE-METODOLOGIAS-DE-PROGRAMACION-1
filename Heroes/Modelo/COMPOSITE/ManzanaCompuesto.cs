using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ManzanaCompuesto : IIluminable
    {
        
        private List<Calle> calles;
        private List<Esquina> esquinas;
        private Plaza plaza;

        public ManzanaCompuesto()
        {
            calles = new List<Calle>(4);
            esquinas = new List<Esquina>(4);
        }


        public void Agregar (Calle pCalle, Esquina pEsquina)
        {            
            this.calles.Add(pCalle);            
            this.esquinas.Add(pEsquina);
        }

        public void Agregar(Calle pCalle, Esquina pEsquina, Plaza pPlaza)
        {
            this.calles.Add(pCalle);
            this.esquinas.Add(pEsquina);
            this.plaza = pPlaza;
        }



        public void RevisarYCambiarLamparasQuemadas()
        {
            int intLamparasReparadas = 0;

            intLamparasReparadas += this.plaza.GetCantidadFarolas();
            
            foreach(Calle item in this.calles)
            {
                intLamparasReparadas += item.GetCantidadFarolas();
            }

            foreach (Esquina item in this.esquinas)
            {
                intLamparasReparadas += item.GetCantidadSemaforos();
            }

            Console.WriteLine("LA CANTIDAD DE LAMAPARAS REPARADAS EN LA MANZANA SON " + intLamparasReparadas);
            
        }
    }
}
