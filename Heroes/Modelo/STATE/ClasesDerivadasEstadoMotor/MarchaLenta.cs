using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class MarchaLenta : EstadoMotor
    {
        public MarchaLenta (IVehiculo pVehiculo) : base(pVehiculo) { }

        public override void acelerar()
        {
            Console.WriteLine("ACELERANDO A MARCHA MEDIA");
            vehiculo.setCambioEstado(new MediaMarcha(vehiculo));
        }

        public override void desacelerar()
        {
            Console.WriteLine("DESACELERANDO PARA FRENAR");
            vehiculo.setCambioEstado(new PuntoMuerto(vehiculo));
        }

        public override void frenar()
        {
            Console.WriteLine("FRENANDO VEHICULO");
            vehiculo.setCambioEstado(new PuntoMuerto(vehiculo));
        }

        public override Boolean apagar()
        {
            Console.WriteLine("SE ROMPIO EL VEHICULO");
            vehiculo.setCambioEstado(new Roto(vehiculo));
            return false;
        }

    }
}
