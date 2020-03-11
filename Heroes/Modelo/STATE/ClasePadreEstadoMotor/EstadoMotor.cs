using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class EstadoMotor 
    {
        //ESTADO
        protected IVehiculo vehiculo;

        //CONSTRUCTOR
        public EstadoMotor(IVehiculo pVehiculo)
        {
            this.vehiculo = pVehiculo;
        }

        //METODOS 
        public virtual void encender()
        {
            Console.WriteLine("SIN EFECTO");
        }
        public virtual void acelerar()
        {
            Console.WriteLine("SIN EFECTO");
        }

        public virtual void desacelerar()
        {
            Console.WriteLine("SIN EFECTO");
        }

        public virtual void frenar()
        {
            Console.WriteLine("SIN EFECTO");
        }

        public virtual void arreglar()
        {
            Console.WriteLine("SIN EFECTO");
        }

        public virtual Boolean apagar()
        {
            Console.WriteLine("SIN EFECTO");
            return true;
           
        }


    }
}
