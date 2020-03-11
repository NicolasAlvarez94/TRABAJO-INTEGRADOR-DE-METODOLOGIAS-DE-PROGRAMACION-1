using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class IteratorDenunciasPorWhatsapp : IIteratorDenuncia
    {        
        private MensajeWhatsapp listaEnlazada;

        public IteratorDenunciasPorWhatsapp(MensajeWhatsapp pListaEnlazada)
        {
            this.listaEnlazada = pListaEnlazada;            
        }
        public IDenuncia actual()
        {
            return this.listaEnlazada.getDenuncia();
        }
        public bool fin()
        {
            return this.listaEnlazada == null;
        }    
        public void siguiente()
        {
            this.listaEnlazada =  this.listaEnlazada.getSiguiente();
        }
    }
}
