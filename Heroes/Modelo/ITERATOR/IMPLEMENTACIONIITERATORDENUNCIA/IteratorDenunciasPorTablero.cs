using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class IteratorDenunciasPorTablero : IIteratorDenuncia
    {
        private List<IDenuncia> denuncias;
        private int denunciaActual;

        public IteratorDenunciasPorTablero(List<IDenuncia> pDenuncias)
        {
            this.denuncias = pDenuncias;
            this.denunciaActual = 0;
        }

        public IDenuncia actual()
        {
            IDenuncia lugarDeDenuncia = denuncias[denunciaActual];
            return lugarDeDenuncia;
        }

        public bool fin()
        {
            return this.denunciaActual >= this.denuncias.Count;
        }

        public void siguiente()
        {
            this.denunciaActual++;
        }
   
    }
}
