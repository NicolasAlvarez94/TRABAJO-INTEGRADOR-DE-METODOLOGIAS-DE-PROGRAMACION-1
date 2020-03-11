using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class ProtocoloRCP
    {
        //COMPOSICION DE OBJETOS CON LA IHERRAMIENTA DEL MEDICO (LO HEREDAN LOS PROTOCOLOS Y LA INSTANCIAN A LA HORA DE USAR LA HERRAMIENTA)
        protected IHerramienta herramienta;

              
        //METODO PLANTILLA 
        public void AtenderInfarto(IInfartable infartable)
        {            
            EliminarObjetosBoca();
            ComprobarEstadoConciencia();

            if (infartable.estasConciente() == false)
            {
                //LlamarAmbulancia(); 
                DescubrirTorax();
                AcomodarCabeza();
                Boolean respira = infartable.estasRespirando();

                if (respira)
                    Console.WriteLine("EL PACIENTE ESTA RESPIRANDO");
                else
                {
                    while (respira == false)
                    {
                        HacerCompresionesToracicas();
                        HacerInsuflaciones();
                        if (infartable.tenesRitmoCardiaco() == false)
                            UsarDesfibrilador();
                        if (CantidadVecesReanimacion())
                        {
                            Console.WriteLine("YA NO SE PUEDE HACER NADA, LO PERDIMOS");
                            respira = true;
                        }
                        respira = infartable.estasRespirando();
                        if (respira)
                        {
                            Console.WriteLine("EL PACIENTE YA ESTA RESPIRANDO GRACIAS A DIOS");
                            GuardarDesfibrilador();
                        }
                    }
                }
            }
            else
                Console.WriteLine("EL PACIENTE ESTA CONCIENTE !!!");
        }


        //METODOS ABSTRACTOS QUE TIENEN QUE SER IMPLEMENTADOS POR LAS CLASES PROTOCOLOA Y PROTOCOLOB
        protected abstract void EliminarObjetosBoca();
        protected abstract void ComprobarEstadoConciencia();
        protected abstract void LlamarAmbulancia();
        protected abstract void DescubrirTorax();
        protected abstract void AcomodarCabeza();
        protected abstract void HacerCompresionesToracicas();
        protected abstract void HacerInsuflaciones();
        protected abstract void UsarDesfibrilador();
        protected abstract void GuardarDesfibrilador();


        //METODO CON MODIFICADOR VIRTUAL PARA SER SOBREESCRITO POR LA CLASE DERIVADA PROTOCOLOA, PARA AGREGAR IMPLEMENTACION
        //DE CANTIDAD DE VECES DE REANIMACION
        protected virtual Boolean CantidadVecesReanimacion() { return false; }

    }
}
