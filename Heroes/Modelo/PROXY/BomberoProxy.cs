using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    //BOMBERO PROXY HEREDA DE MANEJADOR POR LO TANTO ES UN IRESPONSABLE
    class BomberoProxy : Manejador
    {
        //ESTADO
        IFabricaDeHeroes fabrica;

        public BomberoProxy(Manejador manejador, FabricaDeBomberos fabrica) : base(manejador)
        {
            this.fabrica = fabrica;
        }


        //SOBREESCRIBIENDO EL METODO APAGAR INCENDIO


        public override void ApagarIncendio2(ILugar pLugar, Calle pCalle)
        {
            IResponsable bombero =  fabrica.crearHeroe();
            IHerramienta manguera = fabrica.crearHerramienta();
            IVehiculo autobomba = fabrica.crearVehiculo();

            //USO DE PATRON SINGLETON
            CuartelDeBomberos cuartel = CuartelDeBomberos.getCuartelBombero();
            //SE AGREGA AL CUARTEL
            cuartel.agregarPersonal(bombero);
            cuartel.agregarHerramienta(manguera);
            cuartel.agregarVehiculo(autobomba);

            //OBTENGO EL BOMBERO RESPONSABLE
            Bombero bomberoResponsable = (Bombero) cuartel.getPersonal();
            //LE ASIGNO UNA ESTRATEGIA
            bomberoResponsable.setEstrategia(new Escalera());

            //DELEGO LA TAREA AL VERDADERO BOMBERO, PASANDO EL ILUGAR Y LA CALLE 
            bomberoResponsable.ApagarIncendio2(pLugar , pCalle);
        }

    }
}
