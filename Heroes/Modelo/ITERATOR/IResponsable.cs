using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface IResponsable
    {

        void PatrullarCalles(IPatrullable pPatrullaje);


        void Revisar(IIluminable pIluminable);


        void AtenderInfarto(IInfartable infartable);


        void ApagarIncendio2(ILugar pLugar, Calle pCalle);
    
    }
}
