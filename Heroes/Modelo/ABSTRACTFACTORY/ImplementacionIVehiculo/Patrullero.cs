using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Patrullero : IVehiculo
    {
        EstadoMotor estado;

        public Patrullero()
        {
            //this.estado = new Apagado(this);
        }

        public void setCambioEstado(EstadoMotor pEstado)
        {
            this.estado = pEstado;
        }

        public Boolean conducir()
        {
            this.estado = new Apagado(this);
            this.encender();
            this.acelerar();
            Console.WriteLine("CONDUCIENDO PATRULLERO");
            this.desacelerar();
            /*HAY UN SIN EFECTO, YA QUE AL DESACELERAR, LUEGO SIGUE LA INSTRUCCION DE FRENAR LA CUAL NO SE ENCUENTRA EN LA CLASE DEL ESTADO
              ACTUAL E INVOCA AL METODO DE LA CLASE PADRE (QUE TIENE UN SIN EFECTO)*/
            this.frenar();
            Boolean boolVehiculoRoto = this.apagar();
            return boolVehiculoRoto;
        }

        public void encenderSirena()
        {
            Console.WriteLine("ENCENDIENDO SIRENA DE PATRULLERO");
        }


        //METODOS PARTE DEL PATRON STATE
        public void encender()
        {
            this.estado.encender();
        }
        public void acelerar()
        {
            this.estado.acelerar();
        }
        public void desacelerar()
        {
            this.estado.desacelerar();
        }
        public void frenar()
        {
            this.estado.frenar();
        }
        public void arreglar()
        {
            this.estado.arreglar();
        }
        public Boolean apagar()
        {
            return this.estado.apagar();
        }


    }
}
