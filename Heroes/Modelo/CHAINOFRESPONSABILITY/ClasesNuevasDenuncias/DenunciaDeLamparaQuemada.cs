using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciaDeLamparaQuemada : IDenuncia
    {
        IIluminable iluminable;

        public DenunciaDeLamparaQuemada (IIluminable pIluminable)
        {
            this.iluminable = pIluminable;
        }

        public void Atender(IResponsable pResponsable)
        {
            pResponsable.Revisar(this.iluminable);
        }
    }
}
