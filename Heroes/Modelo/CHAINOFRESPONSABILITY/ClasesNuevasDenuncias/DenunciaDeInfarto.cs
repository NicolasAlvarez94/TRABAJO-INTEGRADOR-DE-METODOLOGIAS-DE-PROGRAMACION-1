using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciaDeInfarto : IDenuncia
    {
        IInfartable infartable;

        public DenunciaDeInfarto(IInfartable pInfartable)
        {
            this.infartable = pInfartable;
        }


        public void Atender(IResponsable pResponsable)
        {            
            pResponsable.AtenderInfarto(this.infartable);                       
        }
    }
}
