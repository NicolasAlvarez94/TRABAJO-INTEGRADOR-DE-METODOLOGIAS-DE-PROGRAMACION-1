using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    abstract class FabricaDeDecorados
    {
        //METODO FABRICA QUE HAY QUE PASARLE COMO ARGUMENTO UN DATO A CIERTAS FABRICAS QUE LO NECESITAN  PARA CREAR LOS DECORADOS Y PODER LLEVAR A CABO SU FUNCIONALIDAD
        public static ISector CrearDecorado(int pOpcion, ISector PSector, int pDatoDeDecorado)
        {
            FabricaDeDecorados decorado = null;
            switch (pOpcion)
            {
                case 1:
                    decorado = new FabricaDecoradorPastoSeco();
                    break;
                case 2:
                    decorado = new FabricaDecoradoArbolesGrandes();
                    break;
                case 3:
                    decorado = new FabricaSectorSimple();
                    break;
                case 4:
                    decorado = new FabricaDecoradoDiaLLuvioso(pDatoDeDecorado);
                    break;
                case 5:
                    decorado = new FabricaDecoradoDiaVentoso(pDatoDeDecorado);
                    break;
                case 6:
                    decorado = new FabricaDecoradorGenteAsustada(pDatoDeDecorado);
                    break;
                case 7:
                    decorado = new FabricaDecoradorMuchoCalor(pDatoDeDecorado);
                    break;
            }            
            return decorado.CrearDecorado(PSector);
        }

        
        //METODO ABSTRACTO IMPLEMENTADO POR TODAS LAS CLASES DERIVADAS PARA CREAR LA INSTANCIA CONCRETA DE UN DECORADO
        public abstract ISector CrearDecorado(ISector pSector);

    }
}
