using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciaDeIncendio : IDenuncia
    {
        private ILugar lugarDeIncendio;
        private Calle calle;


        public DenunciaDeIncendio(ILugar pLugar, Calle pCalle)
        {
            this.lugarDeIncendio = pLugar;
            this.calle = pCalle;
        }



        public void setLugarDeIncendio(ILugar pLugar)
        {
            this.lugarDeIncendio = pLugar;
        }

        public ILugar getLugarDeIncendio()
        {
            return this.lugarDeIncendio;
        }


        public void Atender(IResponsable pResponsable)
        {
            pResponsable.ApagarIncendio2(this.lugarDeIncendio, this.calle);                         
        }
    }
}
