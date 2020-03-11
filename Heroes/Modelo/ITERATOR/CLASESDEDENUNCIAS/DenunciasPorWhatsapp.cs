using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciasPorWhatsapp : IDenuncias
    {
        MensajeWhatsapp listaEnlazada;

        public DenunciasPorWhatsapp(MensajeWhatsapp pListaLugares)
        {
            listaEnlazada = pListaLugares;
            
        }

        public IIteratorDenuncia ConstruirIterador()
        {
            return new IteratorDenunciasPorWhatsapp(this.listaEnlazada);
        }
    }
}
