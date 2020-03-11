using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class Manejador : IResponsable
    {
        private Manejador manejador = null;

        public Manejador() { }

        public Manejador(Manejador pManejador)
        {
            this.manejador = pManejador;
        }

        public virtual void PatrullarCalles(IPatrullable pPatrullaje)
        {
            if (this.manejador != null)
                this.manejador.PatrullarCalles(pPatrullaje);
        }

        public virtual void Revisar(IIluminable pIluminable)
        {
            if (this.manejador != null)
                this.manejador.Revisar(pIluminable);
        }

        public virtual void AtenderInfarto(IInfartable infartable)
        {
            if (this.manejador != null)
                this.manejador.AtenderInfarto(infartable);
        }

        public virtual void ApagarIncendio2(ILugar pLugar, Calle pCalle)
        {
            if (this.manejador != null)
                this.manejador.ApagarIncendio2(pLugar, pCalle);
        }



    }
}
