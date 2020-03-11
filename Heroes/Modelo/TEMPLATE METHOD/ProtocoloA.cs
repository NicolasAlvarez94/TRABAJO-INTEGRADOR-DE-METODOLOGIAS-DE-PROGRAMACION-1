using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes 
{
    class ProtocoloA : ProtocoloRCP
    {
        //VARIABLE DE CLASE QUE LLEVA LA CUENTA DE LA CANTIDAD DE VECES DE REANIMACION
        private static int cantidadDeVecesDeReanimacion = 0;
   
        protected override void AcomodarCabeza()
        {
            Console.WriteLine("ACOMODANDO LA CABEZA CON EL PROTOCOLO A");
        }

        protected override void ComprobarEstadoConciencia()
        {
            Console.WriteLine("COMPROBANDO ESTADO DE CONCIENCIA CON EL PROTOCOLO A");
        }

        protected override void DescubrirTorax()
        {
            Console.WriteLine("DESCUBRIENDO TORAX CON EL PROTOCOLO A");
        }

        protected override void EliminarObjetosBoca()
        {
            Console.WriteLine("ELIMINANDO OBJETOS DE LA BOCA CON EL PROTOCOLO A");
        }

        protected override void HacerCompresionesToracicas()
        {
            Console.WriteLine("HACIENDO COMPRESIONES TORACICAS CON EL PROTOCOLO A");
        }

        protected override void HacerInsuflaciones()
        {
            Console.WriteLine("HACIENDO INSUFLACIONES CON EL PROTOCOLO A");
        }

        protected override void LlamarAmbulancia()
        {
            Console.WriteLine("LLAMANDO AMBULANCIA CON EL PROTOCOLO A");
        }

        protected override void UsarDesfibrilador()
        {            
            this.herramienta = new Desfibrilador();
            herramienta.usar();
            Console.Write(" CON EL PROTOCOLO A");
            Console.WriteLine();
        }

        protected override void GuardarDesfibrilador()
        {
            this.herramienta = new Desfibrilador();
            herramienta.guardar();
        }


        //METODO QUE INCREMENTA LA CANTIDAD DE VECES DE REANIMACION DE UN PACIENTE
        protected override Boolean CantidadVecesReanimacion()
        {
            cantidadDeVecesDeReanimacion++;
            return cantidadDeVecesDeReanimacion >= 5;
        }

     
    }
}
