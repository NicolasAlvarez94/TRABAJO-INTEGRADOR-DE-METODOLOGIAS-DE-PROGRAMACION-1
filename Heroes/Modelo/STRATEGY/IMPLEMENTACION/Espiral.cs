using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Espiral : IEstrategy
    {
        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            ISector [,] matrizLugar = pLugar.getSectores();

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
                    DeterminarApagado(matrizLugar, filas, intLimiteFila, intAguaDisponible);
                    intContador++;
                }
                for (int columnasReversa = intLimiteColumna - 1; columnasReversa >= intInicio; columnasReversa--)
                {
                    DeterminarApagado(matrizLugar, intLimiteColumna, columnasReversa, intAguaDisponible);
                    intContador++;
                }
                for (int i = intLimiteFila - 1; i > intInicio; i--)
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




        private void DeterminarApagado(ISector [,] pMatrizLugar, int pfilas, int pColumnas, int pCantidadAgua)
        {
            string strResultado = "(" + pfilas + " , " + pColumnas + ") --> ";
            ISector sector = pMatrizLugar[pfilas, pColumnas];
            Boolean boolApagado = sector.EstaApagado();

            if (boolApagado == true)
            {
                boolApagado = true;
                strResultado += sector.getPorcentajeAfectacionFuego() + " --> 0";
                Console.WriteLine(strResultado);
            }
            else
            {
                strResultado += sector.getPorcentajeAfectacionFuego();
                sector.Mojar(pCantidadAgua);
                boolApagado = sector.EstaApagado();
                if (boolApagado == true) { strResultado += " --> 0"; }
                while (boolApagado == false)
                {
                    strResultado += " --> " + sector.getPorcentajeAfectacionFuego();
                    sector.Mojar(pCantidadAgua);
                    if (sector.EstaApagado() == true)
                    {
                        strResultado += " --> 0";
                        boolApagado = true;
                    }
                }
                Console.WriteLine(strResultado);
            }            
        }





    }
}
