using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class IteratorDenunciasPorMostrador : IIteratorDenuncia
    {
        private int denunciaActual;
        private IDenuncia denuncia;

        public IteratorDenunciasPorMostrador(IDenuncia pDenuncia)
        {
            this.denuncia = pDenuncia;
            this.denunciaActual = 0;
        }

        public IDenuncia actual()
        {            
            return denuncia;
        }

        public bool fin()
        {
            return this.denunciaActual >= 1;
        }


        public void siguiente()
        {
            this.denunciaActual++;
        }
    }
}
