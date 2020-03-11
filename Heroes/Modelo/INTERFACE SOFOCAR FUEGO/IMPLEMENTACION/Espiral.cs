using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Espiral : SofocarFuego
    {
        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            int[,] matrizLugar = pLugar.getSectores();

            int intInicio = 0;
            int intLimiteColumna = matrizLugar.GetLength(1) - 1;
            int intLimiteFila = matrizLugar.GetLength(0) - 1;
            int intCantidadElementos = matrizLugar.GetLength(1) * matrizLugar.GetLength(0);
            int intContador = 0;

            while (intContador < intCantidadElementos)
            {
                for (int columnas = intInicio; columnas <= intLimiteColumna; columnas++)
                {
                    DeterminarApagado(matrizLugar, intInicio, columnas, intAguaDisponible);
                    intContador++;
                }
                for (int filas = intInicio + 1; filas <= intLimiteFila; filas++)
                {
                    DeterminarApagado(matrizLugar, filas, intLimiteFila,intAguaDisponible);
                    intContador++;
                }
                for (int columnasReversa = intLimiteColumna -1 ; columnasReversa >= intInicio; columnasReversa--)
                {
                    DeterminarApagado(matrizLugar, intLimiteColumna, columnasReversa, intAguaDisponible);
                    intContador++;
                }
                for (int i = intLimiteFila - 1; i > intInicio ; i--)
                {
                    DeterminarApagado(matrizLugar, i, intInicio, intAguaDisponible);
                    intContador++;
                }

                intInicio = intInicio + 1;
                intLimiteColumna = intLimiteColumna - 1;
                intLimiteFila = intLimiteFila - 1;
            }
            Console.WriteLine("EL FUEGO DE LUGAR FUE EXTINGUIDO EN SU TOTALIDAD");
        }




        private void DeterminarApagado(int[,] pMatrizLugar, int pfilas, int pColumnas, int pCantidadAgua)
        {
            int intSector = pMatrizLugar[pfilas, pColumnas];
            int intResultadoSector = intSector - pCantidadAgua;
            string strResultado = "(" + pfilas + " , " + pColumnas + ") --> " + intSector;

            if (intResultadoSector < 0)
            {
                strResultado += " --> 0";
                Console.WriteLine(strResultado);
            }
            //SI EL RESULTADO DEL SECTOR ES MAYOR SIGNIFICA QUE NO SE APAGO
            else
            {
                strResultado += " --> " + intResultadoSector;
                Boolean boolEntrar = true;
                while (boolEntrar)
                {
                    int intTerminarApagar = intResultadoSector - pCantidadAgua;
                    if (intTerminarApagar < 0)
                    {
                        strResultado += "--> 0";
                        Console.WriteLine(strResultado);
                        boolEntrar = false;
                    }
                    else
                    {
                        strResultado += " --> " + intTerminarApagar;
                    }
                }
            }
        }
    }
}
