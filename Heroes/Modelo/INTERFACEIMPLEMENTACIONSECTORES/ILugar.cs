using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface ILugar : IObservado
    {
        
        //ISector [,] getSectores(ConstructorSector pSector);

        ISector[,] getSectores();
        void Chispa();
    

    }
}
