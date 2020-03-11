using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class MediaMarcha : EstadoMotor
    {
        public MediaMarcha (IVehiculo pVehiculo): base(pVehiculo) { }

        public override void acelerar()
        {
            Console.WriteLine("ACELERANDO A TODA LA VELOCIDAD");
            vehiculo.setCambioEstado(new ATodaVelocidad(vehiculo));
        }

        public override void desacelerar()
        {
            Console.WriteLine("DESACELERANDO A MARCHA LENTA");
            vehiculo.setCambioEstado(new MarchaLenta(vehiculo));
        }

        public override void frenar()
        {
            Console.WriteLine("FRENANDO VEHICULO");
            vehiculo.setCambioEstado(new PuntoMuerto(vehiculo));
        }

        public override Boolean apagar()
        {
            Console.WriteLine("SE ROMPIO EL VEHICULO");
            vehiculo.setCambioEstado(new Roto (vehiculo));
            return false;
        }

    }
}
