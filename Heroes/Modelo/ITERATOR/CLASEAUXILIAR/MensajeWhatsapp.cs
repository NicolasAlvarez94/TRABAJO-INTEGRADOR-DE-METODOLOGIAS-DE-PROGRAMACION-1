using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class MensajeWhatsapp
    {
        IDenuncia denuncia;
        MensajeWhatsapp lista;


        //CONSTRUCTOR DE LA CLASE SE LE PASA COMO PARAMETRO UNA DENUNCIADEINCENDIO (ESTE DEBE CONTENER EL ILUGAR)
        public MensajeWhatsapp(IDenuncia pDenuncia, MensajeWhatsapp pLista)
        {
            this.denuncia = pDenuncia;
            this.lista = pLista;
        }


        public IDenuncia getDenuncia()
        {
            return this.denuncia;
        }

        public MensajeWhatsapp getSiguiente()
        {
            return this.lista;
        }


    }
}
