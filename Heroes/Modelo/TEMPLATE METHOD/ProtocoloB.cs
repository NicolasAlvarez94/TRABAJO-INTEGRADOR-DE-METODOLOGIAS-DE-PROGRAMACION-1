using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class ProtocoloB : ProtocoloRCP
    {           
        protected override void AcomodarCabeza()
        {
            Console.WriteLine("ACOMODANDO LA CABEZA CON EL PROTOCOLO B");
        }

        protected override void ComprobarEstadoConciencia()
        {
            Console.WriteLine("COMPROBANDO ESTADO DE CONCIENCIA CON EL PROTOCOLO B");
        }

        protected override void DescubrirTorax()
        {
            Console.WriteLine("DESCUBRIENDO TORAX CON EL PROTOCOLO B");
        }

        protected override void EliminarObjetosBoca()
        {
            Console.WriteLine("ELIMINANDO OBJETOS DE LA BOCA CON EL PROTOCOLO B");
        }
 
        protected override void HacerCompresionesToracicas()
        {
            Console.WriteLine("HACIENDO COMPRESIONES TORACICAS CON EL PROTOCOLO B");
        }

        protected override void HacerInsuflaciones()
        {
            Console.WriteLine("HACIENDO INSUFLACIONES CON EL PROTOCOLO B");
        }

        protected override void LlamarAmbulancia()
        {
            Console.WriteLine("LLAMANDO AMBULANCIA CON EL PROTOCOLO B");
        }

        protected override void UsarDesfibrilador()
        {
            this.herramienta = new Desfibrilador();
            herramienta.usar();
            Console.Write(" CON EL PROTOCOLO B");
            Console.WriteLine();
        }

        protected override void GuardarDesfibrilador()
        {
            this.herramienta = new Desfibrilador();
            herramienta.guardar();
        }



    }
}
