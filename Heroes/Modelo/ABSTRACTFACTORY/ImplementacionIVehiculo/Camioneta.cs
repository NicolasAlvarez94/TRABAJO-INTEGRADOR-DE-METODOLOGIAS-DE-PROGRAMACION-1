using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Camioneta : IVehiculo
    {
        EstadoMotor estado;

        public Camioneta()
        {            
            /*SOLO SE INSTANCIABA AL PRINCIPIO EN LA CLASE PROGRAM (PROBLEMA) AL TRASCURRIR EL PROGRAMA CON LAS DENUNCIAS
              EL ESTADO PERMANECIA SIN INSTANCIAR, LO CUAL A LLAMAR A LOS METODOS CORRESPONDIENTES DEL ESTADO LO DERIVABA
              A LA CLASE PADRE ABSTRACTA*/
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
            Console.WriteLine("CONDUCIENDO CAMIONETA");
            this.acelerar();
            Boolean boolVehiculoRato = this.apagar();
            return boolVehiculoRato;            
        }

        public void encenderSirena()
        {
            Console.WriteLine("ENCENDIENDO SIRENAS DE CAMIONETA");
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
