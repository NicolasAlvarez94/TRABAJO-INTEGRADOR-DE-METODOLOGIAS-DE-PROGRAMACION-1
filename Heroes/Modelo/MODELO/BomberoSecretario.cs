using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class BomberoSecretario
    {
        Bombero bombero;

        public BomberoSecretario(Bombero pBombero)
        {
            this.bombero = pBombero;
        }
        
        public void atenderDenuncias(IDenuncias denuncia)
        {
            IIteratorDenuncia iterator = denuncia.ConstruirIterador();
            while(!iterator.fin())
            {
                iterator.actual().Atender(bombero);
                iterator.siguiente();
            }
        }

    }
}
