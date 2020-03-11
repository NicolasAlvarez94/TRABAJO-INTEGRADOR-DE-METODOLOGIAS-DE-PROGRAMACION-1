using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Calle : IIluminable
    {
        //PROPIEDADES
        private int longitudMetros;
        private int cantidadFarolas;
        private int caudalAguaPorMinuto;

        //CONSTRUCTORES

        public Calle(int plongitudMetros , int pcantidadFarolas, int pcaudalAguaPorMinuto)
        {
            this.longitudMetros = plongitudMetros;
            this.cantidadFarolas = pcantidadFarolas;
            this.caudalAguaPorMinuto = pcaudalAguaPorMinuto;
        }

        public Calle() { }


        public Calle(int pcaudalAguaPorMinuto)
        {
            this.caudalAguaPorMinuto = pcaudalAguaPorMinuto;
        }






        //METODOS DE ACCESO
        public void SetLongitudMetros(int pNumero)
        {
            this.longitudMetros = pNumero;
        }

        public int GetLongitudMetros()
        {
            return longitudMetros;
        }

        public void SetCantidadFarolas(int pNumero)
        {
            this.cantidadFarolas = pNumero;
        }

        public int GetCantidadFarolas()
        {
            return cantidadFarolas;
        }

        public void SetCaudalAguaPorMinuto(int pNumero)
        {
            this.caudalAguaPorMinuto = pNumero;
        }

        public int GetCaudalAguaPorMinuto()
        {
            return caudalAguaPorMinuto;
        }

        public void RevisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("SE REVISO Y CAMBIO LAMAPARAS QUEMADAS EN CALLE");
        }
    }
}
