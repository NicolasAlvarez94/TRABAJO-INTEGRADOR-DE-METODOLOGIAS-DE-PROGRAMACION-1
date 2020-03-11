using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Transeunte : IInfartable
    {
        //PROBABILIDAD DE QUE UN PACIENTE ESTE RESPIRANDO, INCONCIENTE O TENGA RITMO CARDIACO 
        private const int intProbabilidad = 15;

        //INSTANCIA DE CLASE RANDOM PARA GENERAR NUMEROS ALEATORIOS EN TODOS LOS METODOS
        private Random objAleatorios = new Random();
        

        //METODOS QUE RETORNAN BOOLEANOS SEGUN LA EVALUACIONA DE LA CONDICION DE LA PROBABILIDAD
        public bool estasConciente()
        {
            int intAleatorio = objAleatorios.Next(0,50);
            if (intAleatorio < intProbabilidad)            
                return true;            
            else
                return false;            
        }

        public bool estasRespirando()
        {
            int intAleatorio = objAleatorios.Next(0, 50);
            if (intAleatorio < intProbabilidad)
                return true;
            else
                return false;
        }

        public bool tenesRitmoCardiaco()
        {
            int intAleatorio = objAleatorios.Next(0, 50);
            if (intAleatorio < intProbabilidad)
                return true;
            else
                return false;
        }
    }
}
