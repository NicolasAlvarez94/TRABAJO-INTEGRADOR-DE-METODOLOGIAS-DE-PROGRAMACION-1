using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Policia : Manejador
    {

        //EL POLICIA ES UN IRESPONSABLE POR HERENCIA

        //PROPIEDADES
        Iorden ordenPolicial;
        IHerramienta herramienta;
        IVehiculo vehiculo;

        //SOBRECARGA DE CONSTRUCTORES
        public Policia(Manejador manejador, Iorden pOrden, IHerramienta h, IVehiculo v):base(manejador)
        {
            this.ordenPolicial = pOrden;
            this.herramienta = h;
            this.vehiculo = v;
        } 
        
        public Policia() { }


        //METODOS DE ACCESO
        public void setOrdenPolicial(Iorden orden)
        {
            this.ordenPolicial = orden;
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

        
        //METODOS DEL POLICIA

        //METODO MODIFICADO
        public override void PatrullarCalles(IPatrullable pPatrullaje)
        {
            if (pPatrullaje.hayAlgoFueraDeLoNormal())
            {
                this.vehiculo.encenderSirena();
                if (this.vehiculo.conducir())
                {
                    ordenPolicial.Ejecutar();
                    this.herramienta.usar();                    
                    this.herramienta.guardar();
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("NO PUEDO LLEGAR DONDE A OCURRIDO EL HECHO DELICTIVO. SE ME HA ROTO EL PATRULLERO");                                
            }                
            else
                Console.WriteLine("ESTA TODO EN ORDEN");
        }


        //METODO PATRULLAR CALLES DEL PATRON COMMAND 
        public void PatrullarCallesCommand(IPatrullable pPatrullaje)
        {
            if (pPatrullaje.hayAlgoFueraDeLoNormal())
                ordenPolicial.Ejecutar();
            else
                Console.WriteLine("ESTA TODO EN ORDEN");
        }



        public void DetenerDelicuente()
        {
            Console.WriteLine("DELICUENTE DETENIDO");
        }




    }
}
