using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DenunciasPorTablero : IDenuncias, IObservador
    {
      
        //LISTA DE DENUNCIAS DE INCENDIOS DE LOS LUGARES DONDE SE ACTIVO LA ALARMA
        List<IDenuncia> denuncias = new List<IDenuncia>();
  
        /*RECIBE UN ILUGAR Y SE LE LO PASA COMO PARAMETRO A UNA INSTACIA DE DENUNCIADEINCENDIO, EL CUAL LO ALMACENA EN SU 
         ESTADO. POSTERIORMENTE LA INSTANCIA ES AGREGADO A LA LISTA DE LA CLASE DE DENUNCIAS*/
        public void Actualizar(ILugar pObservado, Calle pCalle)
        {
            DenunciaDeIncendio denuncia = new DenunciaDeIncendio(pObservado, pCalle);
            denuncias.Add(denuncia);
        }

        public List<IDenuncia> getDenuncias()
        {
            return denuncias;
        }

        public IIteratorDenuncia ConstruirIterador()
        {
            return new IteratorDenunciasPorTablero(this.denuncias);
        }
    }
}
