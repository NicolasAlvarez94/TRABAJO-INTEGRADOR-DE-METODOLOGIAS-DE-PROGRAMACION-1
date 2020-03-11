using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Plaza : ILugar, IIluminable, IPatrullable, IObservado
    {
        //PROPIEDADES        
        private int superficieMetrosCuadrados;
        private int cantidadFarolas;
        private int cantidadArboles;
        //LA PLAZA DISPONE UNA CALLE PARA PASARLE AL METODO ACTUALIZAR DE BOMBERO, AL MOMENTO QUE NOTIFICAN A SUS OBSERVADORES
        private Calle objCalle;

        //CONSTRUCTOR CONCRETO PARA PASARLE POR PARAMETRO AL METODO ESTATICO DE LA CLASE DIRECTOR
        ConstructorSector constructorConcreto;

        
        
        //*******************************************************************************************************

        //CONSTRUCTORES Y SOBRECARGAS

        public Plaza() { }
                  
        public Plaza(Calle pCalle, int pSuperficie)
        {
            this.objCalle = pCalle;
            this.superficieMetrosCuadrados = pSuperficie;            
        }

        public Plaza(Calle pCalle, int pSuperficie, ConstructorSector constructor)
        {
            this.objCalle = pCalle;
            this.superficieMetrosCuadrados = pSuperficie;
            this.constructorConcreto = constructor;
        }


        public Plaza(int pSuperficie, ConstructorSector constructor)
        {           
            this.superficieMetrosCuadrados = pSuperficie;            
            this.constructorConcreto = constructor;
        }
        
        public Plaza(ConstructorSector constructor)
        {            
            this.constructorConcreto = constructor;
        }


        //*******************************************************************************************************

        //METODOS DE ACCESO

        public void SetSuperficieMetrosCuadrados(int pNumero)
        {
            this.superficieMetrosCuadrados = pNumero;
        }

        public int GetSuperficieMetrosCuadrados()
        {
            return superficieMetrosCuadrados;
        }

        public void SetCantidadFarolas(int pNumero)
        {
            this.cantidadFarolas = pNumero;
        }

        public int GetCantidadFarolas()
        {
            return cantidadFarolas;
        }

        public void SetCantidadArboles(int pNumero)
        {
            this.cantidadArboles = pNumero;
        }
        public int GetCantidadArboles()
        {
            return cantidadArboles;
        }

        public void setObjCalle(Calle pCalle)
        {
            this.objCalle = pCalle;
        }

        public Calle getObjCalle()
        {
            return objCalle;
        }



        //*******************************************************************************************************


        //METODO PARA CONSTRUIR UNA MATRIZ, DELEGA LA RESPONSABILIDAD AL DIRECTOR DEL PATRON BUILDER PARA CONSTRUIRLA

        public ISector[,] getSectores()
        {
            ISector[,] MatrizPlaza = DirectorDeMatriz.ConstruirMatriz(this.superficieMetrosCuadrados, this.constructorConcreto);
            return MatrizPlaza;
        }

        //*******************************************************************************************************

        //PATRON OBSERVER, AGREGA OBSERVADORES (BOMBEROS) Y NOFICA A ESTOS CUANDO SE PRODUCE UN CAMBIO DE ESTADO (SE ACTIVA LA ALARMA DE INCENDIO (METODO CHISPA))

        /*PATRON OBSERVER, AGREGA OBSERVADORES (DENUNCIASPORTABLERO) Y NOTIFICA A ESTAS CUANDO SE PRODUCE UN CAMBIO DE ESTADO (SE ACTIVA LA ALARMA DE INCENDIO (METODO CHISPA))
        FORMA PARTE DEL PATRON ITERATOR*/


        List<IObservador> observadores = new List<IObservador>();

        public void AgregarObservador(IObservador observador)
        {
            this.observadores.Add(observador);
        }

        public void NotificarObservador()
        {
            foreach (IObservador observador in this.observadores)
            {
                observador.Actualizar(this, this.objCalle);
            }
        }

        public void Chispa()
        {
            Console.WriteLine("SUENA LA ALARMA DE INCENDIO EN LA PLAZA ");
            this.NotificarObservador();
        }

        //*******************************************************************************************************


        //METODO PARA ARMAR MATRIZ DE SECTORES
        /*public ISector[,] getSectores()
        {
            int intSuperficiePlaza = this.superficieMetrosCuadrados;
            double raiz = Math.Sqrt(intSuperficiePlaza);
            double valor = Math.Round(raiz);
            int intValor = (int)valor;

            Random random = new Random();
            //MATRIZ DE ISECTORES QUE PUEDE TENER DISTINTOS SECTORES DECORADOS
            ISector[,] MatrizPlaza = new DecoratorSector[intValor, intValor];

            for (int filas = 0; filas < MatrizPlaza.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < MatrizPlaza.GetLength(1); columnas++)
                {
                    int caudalDeAfectacion = random.Next(0, 101);
                    int caudalLluvia = random.Next(-10, 21);
                    int temperatura = random.Next(25, 32);
                    int viento = random.Next(82, 86);
                    MatrizPlaza[filas, columnas] = CrearSector(caudalLluvia, temperatura, viento, caudalDeAfectacion);
                    
                }
            }
            return MatrizPlaza;
        }

        //METODO QUE DECORA UN SECTOR DE ACUERDO A CIERTOS PARAMETROS O PROBABILIDADES (TRABAJA EL PATRON DECORATOR EN CONJUNTO CON FACTORY METHOD)
        public ISector decorarSector(ISector sector, int caudalLluvia, int temperatura, int velocidadViento)
        {
            //AGREGA COMPLICACIONES AL CAUDAL DE AGUA QUE RECIBE CADA SECTOR PARA SU APAGADO
            double probabilidad_de_decorar = 0.2;
            Random random = new Random();
            
            //DECORADO PASTO SECO, COMPLICA EL APAGADO
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecorados.CrearDecorado(1, sector,0);
            //DECORADO ARBOLES GRANDES, COMPLICA EL APAGADO 
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecorados.CrearDecorado(2, sector,0);          
            //DECORADO MUCHO CALOR, COMPLICA EL APAGADO
            if (temperatura > 30)
                sector = FabricaDeDecorados.CrearDecorado(7, sector, temperatura);
            //DECORADO MUCHO VIENTO, COMPLICA EL APAGADO
            if (velocidadViento > 80)
                sector = FabricaDeDecorados.CrearDecorado(5, sector, velocidadViento);
            //DECORADO LLUVIOSO, AYUDA AL APAGADO
            if (caudalLluvia > 0)
                sector = FabricaDeDecorados.CrearDecorado(4, sector, caudalLluvia);

            return sector;
        }

        //METODO QUE RETORNA UN SECTOR DECORADO
        private ISector CrearSector(int caudalLluvia, int temperatura, int velocidadViento, int caudalAfectacion)
        {          
            ISector sector = new Sector(caudalAfectacion);
            return decorarSector(sector, caudalLluvia, temperatura, velocidadViento);
        }*/


        //*******************************************************************************************************        

        public void RevisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("SE REVISO Y CAMBIO LAMAPARAS QUEMADAS EN PLAZA");
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


    }
}
