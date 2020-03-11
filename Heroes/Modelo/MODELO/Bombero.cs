using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Bombero : Manejador, IObservador
    {

        //EL BOMBERO ES UN IRESPONSABLE POR HERENCIA (MANEJADOR ES UN IRESPONSABLE)

        //COMPOSICION DE OBJETOS CON LA ESTRATEGIA
        IEstrategy estrategia;
        IHerramienta herramienta;
        IVehiculo vehiculo;

        //*************************************************************************************************************************

        //SOBRECARGA DE CONSTRUCTORES

        public Bombero(Manejador manejador, IEstrategy estrategia, IHerramienta herramienta, IVehiculo vehiculo) : base (manejador)
        {
            this.estrategia = estrategia;
            this.herramienta = herramienta;
            this.vehiculo = vehiculo;
        }

        public Bombero(IEstrategy pEstrategia)
        {
            this.estrategia = pEstrategia;
        }

        public Bombero() { }

        //*************************************************************************************************************************

        //METODOS DE ACCESO
        public void setHerramienta(IHerramienta pHerramienta)
        {
            this.herramienta = pHerramienta;
        }
        public void setVehiculo(IVehiculo pVehiculo)
        {
            this.vehiculo = pVehiculo;
        }

        public void setEstrategia(IEstrategy estrategia)
        {
            this.estrategia = estrategia;
        }

        public IHerramienta getHerramienta()
        {
            return this.herramienta;
        }
        public IVehiculo getVehiculo()
        {
            return this.vehiculo;
        }

        //*************************************************************************************************************************

        //METODOS

        //METODO APAGARINCENDIO MODIFICADO POR EL PATRON ABSTRACT FACTORY
        public override void ApagarIncendio2 (ILugar pLugar, Calle pCalle)
        {
            this.vehiculo.encenderSirena();
            if (this.vehiculo.conducir())
            {
                this.herramienta.usar();
                this.estrategia.ApagarIncendio(pLugar, pCalle);
                this.herramienta.guardar();
                Console.WriteLine();
            }
            else
                Console.WriteLine("NO PUEDO LLEGAR A PAGAR EL INCENDIO. SE ME HA ROTO LA AUTOBOMBA");                                  
        }
        

        //METODO APAGAR INCENDIO INICIAL, SEGUN LA ESTRATEGIA, DELEGA LA RESPONSABILIDAD A UN ALGORITMO DE LA CLASE DEL PATRON STRATEGY
        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {            
            this.estrategia.ApagarIncendio(pLugar, pCalle);           
        }

        public void BajarGatitoDeArbol()
        {
            Console.WriteLine("SE HA BAJADO EL GATO DEL ARBOL");
        }


        //METODO ACTUALIZAR CORRESPONDIENTE AL PATRON OBSERVER. BOMBERO DEBE IMPLEMENTAR ESTE METODO PORQUE EXTIENDE DE IOBSERVADOR, CUANDO SE PRODUCE UN CAMBIO DE ESTADO SE LLAMA A ESTE
        public void Actualizar(ILugar pObservado, Calle pCalle)
        {
            ApagarIncendio(pObservado, pCalle);            
        }
    }
}
