using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class DirectorDeMatriz
    {
        //EL DIRECTOR ES EL ENCARGADO DE ARMAR LA MATRIZ, SU METODO ES LLAMADO EN LOS ILUGARES Y SE LE ASIGNA EL 
        //VALOR DE LA SUPERFICIE Y UN CONSTRUCTOR CONCRETO PARA EL ARMADO DE CADA SECTOR DE LA MATRIZ EN SU METODO
        public static ISector[,] ConstruirMatriz(int pSuperficieLugar, ConstructorSector constructor)
        {
            int intSuperficiePlaza = pSuperficieLugar;
            double raiz = Math.Sqrt(intSuperficiePlaza);
            double valor = Math.Round(raiz);
            int intValor = (int)valor;

            Random r = new Random();            
            ISector[,] Matriz = new DecoratorSector[intValor, intValor];
            for (int filas = 0; filas < Matriz.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < Matriz.GetLength(1); columnas++)
                {
                    int afectacionSector = r.Next(0, 101);
                    Matriz[filas, columnas] = constructor.ConstruirSector(afectacionSector);
                }
            }
            return Matriz;          
        }
        


    }
}
