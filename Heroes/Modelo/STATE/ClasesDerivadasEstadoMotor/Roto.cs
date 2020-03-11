using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Roto : EstadoMotor
    {
        public Roto (IVehiculo pVehiculo): base(pVehiculo) { }

        public override void arreglar()
        {
            Console.WriteLine("ARREGLANDO VEHICULO");
            vehiculo.setCambioEstado(new Apagado(vehiculo));
        }

    }
}
