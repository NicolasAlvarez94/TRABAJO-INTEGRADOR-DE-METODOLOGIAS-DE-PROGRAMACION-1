using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class Builder
    {
        protected ILugar lugar;
        

        public void ConstruirMatrizLugar(ILugar pLugar)
        {
            this.lugar = pLugar;
        }

        public ISector [,] ObtenerMatrizLugar()
        {
            return lugar.getSectores();
        }

        public abstract ISector ConstruirSector();

    }
}
