using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Operador911
    {
        IResponsable responsable;

        public Operador911 (IResponsable pResponsable)
        {
            this.responsable = pResponsable;
        }

        public void atenderDenuncias(IDenuncias denuncias)
        {
            IIteratorDenuncia iterador = denuncias.ConstruirIterador();
            while (!iterador.fin())
            {
                
                iterador.actual().Atender(this.responsable);
                iterador.siguiente();
            }
            
        }
    }
}
