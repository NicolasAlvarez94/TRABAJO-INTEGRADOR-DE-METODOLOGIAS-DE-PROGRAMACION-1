using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Apagado : EstadoMotor
    {
        public Apagado (IVehiculo pVehiculo): base(pVehiculo) { }

        public override void encender()
        {
            Console.WriteLine("ENCENDIENDO MOTOR");
            vehiculo.setCambioEstado(new PuntoMuerto(vehiculo));            
        }


    }
}
