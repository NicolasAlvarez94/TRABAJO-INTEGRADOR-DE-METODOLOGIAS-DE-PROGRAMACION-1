using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Esquina : IIluminable, IPatrullable
    {
        //ESTADO
        private int cantidadSemaforos;

        //*******************************************************************************************************

        //SOBRECARGA DE CONSTRUCTORES
        public Esquina(int pcantidadSemaforos)
        {
            this.cantidadSemaforos = pcantidadSemaforos;
        }

        public Esquina() { }

        //*******************************************************************************************************


        //METODOS DE ACCESO
        public void SetCantidadSemaforos(int pNumero)
        {
            this.cantidadSemaforos = pNumero;
        }

        public int GetCantidadSemaforos()
        {
            return cantidadSemaforos;
        }

        //*******************************************************************************************************

        //METODOS DE INSTANCIAS
        public void RevisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("SE REVISO Y CAMBIO LAMAPARAS QUEMADAS EN ESQUINA");
        }

        public bool hayAlgoFueraDeLoNormal()
        {
            Random random = new Random();
            int probabilidad = 52;
            int aleatorio = random.Next(0, 50);
            if (aleatorio < probabilidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
