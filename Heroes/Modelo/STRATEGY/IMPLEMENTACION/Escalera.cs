using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Escalera : IEstrategy
    {
        //METODO QUE UTILIZA EL METODO DE GETSECTORES DE LA PLAZA QUE RECIBE UN CONSTRUCTOR CONCRETO
        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            ISector[,] matrizLugar = pLugar.getSectores();

            for (int fila = 0; fila < matrizLugar.GetLength(0); fila++)
            {
                for (int columnas = 0; columnas < matrizLugar.GetLength(1); columnas++)
                {
                    //CUANDO EL NUMERO DE FILA SEA IMPAR (SE TENDRA QUE RECORRER AL REVES PARA DAR EL EFECTO ESCALERA)
                    if (fila % 2 != 0)
                    {
                        for (int columna = matrizLugar.GetLength(1) - 1; columna >= 0; columna--)
                        {
                            DeterminarApagado(matrizLugar, fila, columna, intAguaDisponible);
                        }
                        break;
                    }

                    DeterminarApagado(matrizLugar, fila, columnas, intAguaDisponible);                  
                }                                                                      
            }
            Console.WriteLine("EL FUEGO DE LUGAR FUE EXTINGUIDO EN SU TOTALIDAD");            
        }


        private void DeterminarApagado(ISector[,] pMatrizLugar, int pfilas, int pColumnas, int pCantidadAgua)
        {
            string strResultado = "(" + pfilas + " , " + pColumnas + ") --> ";
            ISector sector = pMatrizLugar[pfilas, pColumnas];                        
            bool boolApagado = sector.EstaApagado();

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
