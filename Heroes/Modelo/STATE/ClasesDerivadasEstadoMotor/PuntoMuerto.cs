using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class PuntoMuerto : EstadoMotor
    {
        public PuntoMuerto (IVehiculo pVehiculo): base(pVehiculo) { }

        public override void acelerar()
        {
            Console.WriteLine("ACELERANDO A MARCHA LENTA");
            vehiculo.setCambioEstado(new MarchaLenta(vehiculo));
        }

        public override Boolean apagar()
        {
            Console.WriteLine("APAGANDO MOTOR");
            vehiculo.setCambioEstado(new Apagado(vehiculo));
            return true;
        }


    }
}
