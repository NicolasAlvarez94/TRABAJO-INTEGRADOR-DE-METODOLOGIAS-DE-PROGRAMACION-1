using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciasPorMostrador : IDenuncias
    {
        IDenuncia denuncia;

        public DenunciasPorMostrador(DenunciaDeIncendio pDenuncia)
        {
            this.denuncia = pDenuncia;
        }

        public IIteratorDenuncia ConstruirIterador()
        {
            return new IteratorDenunciasPorMostrador(this.denuncia);
        }
    }
}
