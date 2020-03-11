using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    //IMPLEMENTACION DE LA INTERFACE
    class Secuencial : IEstrategy
    {

        public void ApagarIncendio(ILugar pLugar, Calle pCalle)
        {
            int intAguaDisponible = pCalle.GetCaudalAguaPorMinuto();
            ISector [,] matrizLugar = pLugar.getSectores();

            for (int filas = 0; filas < matrizLugar.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizLugar.GetLength(1); columnas++)
                {
                    //SE LE PASA DIRECTAMENTE LA MATRIZ, EL NUMERO DE FILA Y COLUMNA DE CADA SECTOR  PARA QUE SE EVALUE LA SITUACION DEL SECTOR
                    DeterminarApagado(matrizLugar, filas, columnas, intAguaDisponible);         
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
