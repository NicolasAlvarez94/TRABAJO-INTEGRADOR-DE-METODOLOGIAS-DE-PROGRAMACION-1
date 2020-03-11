using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Electricista : Manejador
    {
        //EL ELECTRICISTA ES UN IRESPONSABLE POR HERENCIA

        IHerramienta herramienta;
        IVehiculo vehiculo;

        //SOBRECARGA DE CONSTRUCTORES
        public Electricista(Manejador manejador, IHerramienta herramienta, IVehiculo vehiculo) : base (manejador)
        {
            this.herramienta = herramienta;
            this.vehiculo = vehiculo;
        }

        public Electricista() { }


        //METODOS DE ACCESO DE LECTURA Y ESCRITURA
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

        //SOBREESCRIPCION DE METODO 
        public override void Revisar(IIluminable pIluminable)
        {
            this.vehiculo.encenderSirena();
            if (this.vehiculo.conducir())
            {
                this.herramienta.usar();
                pIluminable.RevisarYCambiarLamparasQuemadas();
                this.herramienta.guardar();                
            }
            else
                Console.WriteLine("NO VOY A PODER REVISAR LA LUMINARIA. EL VEHICULO SE HA ROTO");

            Console.WriteLine();                    
        }


        //METODO DE PRUEBA PARA PATRON COMPOSITE
        public void RevisarIluminable(IIluminable pIluminable)
        {
            pIluminable.RevisarYCambiarLamparasQuemadas();        
        }


    }
}
