using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface IObservador
    {
        void Actualizar(ILugar pObservado, Calle pCalle);

        //void Actualizar(Plaza pObservado);



    }
}
