using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Escalera : SofocarFuego
    {

        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            int[,] matrizLugar = pLugar.getSectores();
            for (int filas = 0; filas < matrizLugar.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizLugar.GetLength(1); columnas++)
                {
                    if (filas % 2 != 0)
                    {
                        for (int columna = matrizLugar.GetLength(1) - 1; columna >= 0; columna--)
                        {
                            DeterminarApagado(matrizLugar, filas, columna, intAguaDisponible);
                        }
                        break;
                    }

                    DeterminarApagado(matrizLugar, filas, columnas, intAguaDisponible);                  
                }                                                                      
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
