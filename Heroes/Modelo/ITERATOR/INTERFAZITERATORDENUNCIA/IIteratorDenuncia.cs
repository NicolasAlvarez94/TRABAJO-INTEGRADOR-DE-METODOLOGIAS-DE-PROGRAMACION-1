using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface IIteratorDenuncia
    {       
        void siguiente();
        Boolean fin();
        IDenuncia actual();
    }
}
