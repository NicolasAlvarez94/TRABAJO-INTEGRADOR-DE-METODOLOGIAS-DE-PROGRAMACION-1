using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface IObservado
    {

        void AgregarObservador(IObservador observador);   
        void NotificarObservador();


        
    }
}
