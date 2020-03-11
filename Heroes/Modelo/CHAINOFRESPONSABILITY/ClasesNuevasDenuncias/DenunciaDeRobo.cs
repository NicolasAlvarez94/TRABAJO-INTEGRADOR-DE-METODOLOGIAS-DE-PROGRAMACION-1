using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciaDeRobo : IDenuncia
    {
        IPatrullable patrullable;

        public DenunciaDeRobo(IPatrullable pPatrullable)
        {
            this.patrullable = pPatrullable;
        }

        public void Atender(IResponsable pResponsable)
        {
            pResponsable.PatrullarCalles(this.patrullable);                        
        }
    }
}
