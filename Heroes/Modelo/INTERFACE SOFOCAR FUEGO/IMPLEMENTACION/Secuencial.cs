using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    //IMPLEMENTACION DE LA INTERFACE
    class Secuencial : SofocarFuego
    {
        //debería poder verse:
        //(1, 1)-> 45-> 0

        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            int[,] matrizLugar = pLugar.getSectores();

            for (int filas = 0; filas < matrizLugar.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizLugar.GetLength(1); columnas++)
                {
                    int intSector = matrizLugar[filas, columnas];
                    int intResultadoSector = intSector - intAguaDisponible;
                    string strResultado = "(" + filas + " , " + columnas + ") --> " + intSector;

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
                            int intTerminarApagar = intResultadoSector - intAguaDisponible;                            
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
            Console.WriteLine("EL FUEGO DE LUGAR FUE EXTINGUIDO EN SU TOTALIDAD");
        }




        



    }
}
