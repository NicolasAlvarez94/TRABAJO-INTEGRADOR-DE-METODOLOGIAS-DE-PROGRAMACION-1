using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface IVehiculo
    {
        void encenderSirena();
        Boolean conducir();
        void encender();
        void acelerar();
        void desacelerar();
        void frenar();
        void arreglar();
        Boolean apagar();
        void setCambioEstado(EstadoMotor pEstado);
    }
}
