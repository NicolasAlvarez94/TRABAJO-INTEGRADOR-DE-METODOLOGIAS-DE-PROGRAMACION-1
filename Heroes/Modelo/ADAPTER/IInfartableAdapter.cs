using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class IInfartableAdapter : IInfartable
    {
        //COMPOSICION CON LA CLASE A ADAPTAR
        Passerby passerby;

        //CONSTRUCTOR QUE RECIBE UNA INSTANCIA DE LA CLASE A ADAPTAR
        public IInfartableAdapter(Passerby pPasserby)
        {
            this.passerby = pPasserby;
        }


        //METODOS ORIGINALES DE LA INTERFACE, DELEGA LA TAREA A LOS METODOS DE LA CLASE ADAPTADA (PASSERBY)
        public bool estasConciente()
        {
            return this.passerby.isConscious();
        }

        public bool estasRespirando()
        {
            return this.passerby.isBreathing();
        }

        public bool tenesRitmoCardiaco()
        {
            return this.passerby.haveHeartRate();
            
        }
    }
}
