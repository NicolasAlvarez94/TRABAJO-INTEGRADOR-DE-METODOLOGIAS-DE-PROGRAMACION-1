using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    // IILUMINABLE REPRESENTA LA INTERFACE COMPONENTE DEL PATRON COMPOSITE (LA IMPLEMENTAN PLAZA, CALLE Y ESQUINA)
    interface IIluminable
    {
        void RevisarYCambiarLamparasQuemadas();
    }
}
