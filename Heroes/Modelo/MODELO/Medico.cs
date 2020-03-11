using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Medico : Manejador, IResponsable
    {
        //EL MEDICO ES UN IRESPONSABLE POR HERENCIA

        //ESTADO
        ProtocoloRCP protocolo;
        IHerramienta herramienta;
        IVehiculo vehiculo;

        //*********************************************************************************************************

        //SOBRECARGA DE CONSTRUCTORES
        public Medico (Manejador manejador, ProtocoloRCP pProtocolo, IHerramienta h, IVehiculo v) : base(manejador)
        {
            this.protocolo = pProtocolo;
            this.herramienta = h;
            this.vehiculo = v;
        }

        public Medico() { }

        //*********************************************************************************************************

        //METODOS DE ACCESO DE ESCRITURA Y LECTURA
        public void setProtocolo(ProtocoloRCP Pprotocolo)
        {
            this.protocolo = Pprotocolo;
        }

        public void setHerramienta(IHerramienta pHerramienta)
        {
            this.herramienta = pHerramienta;
        }
        public void setVehiculo(IVehiculo pVehiculo)
        {
            this.vehiculo = pVehiculo;
        }
        public IHerramienta getHerramienta()
        {
            return this.herramienta;
        }
        public IVehiculo getVehiculo()
        {
            return this.vehiculo;
        }

        //*********************************************************************************************************

        //METODOS DE INSTANCIAS

        public void AtenderDesmayo()
        {
            Console.WriteLine("SE ATENDIO DESMAYO");
        }

        //*********************************************************************************************************

        public override void AtenderInfarto(IInfartable infartable)
        {
            this.vehiculo.encenderSirena();
                        
            // IMPLEMENTAR CONDICIONAL PARA VER SI EL VEHICULO LLEGA ROTO O NO / CONDUCIR RETORNA UN BOOLEANO
            if (this.vehiculo.conducir())
            {               
                protocolo.AtenderInfarto(infartable);

                //METODOS ANULADOS CONTEMPLADOS DESDE EL PATRON TEMPLATE METHOD
                //this.herramienta.usar();
                //this.herramienta.guardar();
                Console.WriteLine();
            }
            else
                Console.WriteLine("TENGO UN INCONVENIENTE NO VOY A PODER ATENDER EL INFARTO. EL VEHICULO SE HA ROTO");
            Console.WriteLine();
        }

        //*********************************************************************************************************

        //METODO QUE LLAMA ALA METODO PLANTILLA DEL PATRON TEMPLATE METHOD
        public void AtenderInfartoTemplateMethod(IInfartable infartable)
        {
            this.protocolo = new ProtocoloA();
            protocolo.AtenderInfarto(infartable);
        }



    }
}
