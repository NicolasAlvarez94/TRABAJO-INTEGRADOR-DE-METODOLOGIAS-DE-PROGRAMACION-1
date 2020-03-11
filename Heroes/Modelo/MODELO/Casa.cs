using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Casa : ILugar, IPatrullable, IObservado
    {
        //PROPIEDADES

        private int numeroPuertas;
        private int superficieMetrosCuadrados;
        private int cantidadHabitantes;
        private Calle objCalle;

        //CONSTRUCTOR CONCRETO PARA PASARLE POR PARAMETRO AL METODO ESTATICO DEL DIRECTOR
        ConstructorSector constructorConcreto;

        //*******************************************************************************************************

        //SOBRECARGA DE CONSTRUCTORES
        public Casa(int pnumeroPuertas, int psuperficieMetrosCuadrados, int pcantidadHabitantes)
        {
            this.numeroPuertas = pnumeroPuertas;
            this.superficieMetrosCuadrados = psuperficieMetrosCuadrados;
            this.cantidadHabitantes = pcantidadHabitantes;
        }

        public Casa() { }

        public Casa (Calle calle, int superficie)
        {
            this.objCalle = calle;
            this.superficieMetrosCuadrados = superficie;
        }

        public Casa(ConstructorSector constructor)
        {
            this.constructorConcreto = constructor;
        }


        //*******************************************************************************************************

        //METODOS DE ACCESO 
        public void SetNumeroPuertas(int pNumero)
        {
            this.numeroPuertas = pNumero;
        }

        public int GetNumeroPuertas()
        {
            return numeroPuertas;
        }

        public void SetsuperficieMetrosCuadrados(int pNumero)
        {
            this.superficieMetrosCuadrados = pNumero;
        }

        public int GetsuperficieMetrosCuadrados()
        {
            return superficieMetrosCuadrados;
        }

        public void SetcantidadHabitantes(int pNumero)
        {
            this.cantidadHabitantes = pNumero;
        }

        public int GetcantidadHabitantes()
        {
            return cantidadHabitantes;
        }

        //*******************************************************************************************************

        //METODO QUE DELEGA LA RESPONSABILIDAD AL DIRECTOR DEL PATRON BUILDER DE ARMAR UNA MATRIZ DE SECTORES AFECTADOS
        //public ISector[,] getSectores(ConstructorSector pSector)
        //{
        //    ISector[,] matrizCasa = DirectorDeMatriz.ConstruirMatriz(this.superficieMetrosCuadrados, pSector);
        //    return matrizCasa;
        //}

        //public ISector[,] getSectores()
        //{
        //    ISector[,] matrizCasa = DirectorDeMatriz.ConstruirMatriz(this.superficieMetrosCuadrados, this.constructorConcreto);
        //    return matrizCasa;
        //}


        //*******************************************************************************************************

        //PATRON OBSERVER (PARA BOMBEROS)

        List<IObservador> observadoresBomberos = new List<IObservador>();

        public void AgregarObservador(IObservador observador)
        {
            observadoresBomberos.Add(observador);
        }

        public void NotificarObservador()
        {
            foreach(Bombero bombero in observadoresBomberos)
            {
                bombero.Actualizar(this, this.objCalle);
            }
        }

        public void Chispa()
        {
            Console.WriteLine("SUENA LA ALARMA DE INCENDIO EN LA CASA");
            this.NotificarObservador();
        }


        //*******************************************************************************************************

        ////PATRON OBSERVER, AGREGA OBSERVADORES (DENUNCIASPORTABLERO) Y NOTIFICA A LOS OBJETOS DE LA CLASE CUANDO SE ACTIVA LA ALARMA DE INCENDIO (METODO CHISPA)

        /* List<IObservador> observadoresDeDenuncias = new List<IObservador>();
         public void AgregarObservador(IObservador observador)
         {
             observadoresDeDenuncias.Add(observador);
         }

         public void NotificarObservador()
         {
             foreach (DenunciasPorTablero denuncia in observadoresDeDenuncias)
             {
                 denuncia.Actualizar(this,this.objCalle);
             }
         }

         public void Chispa()
         {
             Console.WriteLine("SUENA LA ALARMA DE INCENDIO EN LA CASA");
             this.NotificarObservador();
         }*/

        //*******************************************************************************************************


        //EX METODO QUE ARMABA SECTORES EN LA PLAZA
        public ISector[,] getSectores()
        {
            int intSuperficieCasa = this.superficieMetrosCuadrados;
            double raiz = Math.Sqrt(intSuperficieCasa);
            double valor = Math.Round(raiz);
            int intValor = (int)valor;

            Random r = new Random();
            ISector[,] MatrizCasa = new Sector[intValor, intValor];

            for (int filas = 0; filas < MatrizCasa.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < MatrizCasa.GetLength(1); columnas++)
                {
                    int caudalDeAfectacion = r.Next(0, 101);
                    //Sector sector = (Sector)MatrizCasa[filas, columnas];
                    //sector.setPorcentajeAfectacionFuego(caudalDeAfectacion);
                    Sector sector = new Sector();
                    sector.setPorcentajeAfectacionFuego(caudalDeAfectacion);
                    MatrizCasa[filas, columnas] = sector;
                }
            }
            return MatrizCasa;
        }

        //*******************************************************************************************************

        public bool hayAlgoFueraDeLoNormal()
        {
            Random random = new Random();          
            int aleatorio = random.Next(0, 50);

            int probabilidad = 52;

            if (aleatorio < probabilidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    

        //*******************************************************************************************************

    }
}
