using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {

            pruebaPatronStrategy();
            pruebaPatronObserver();
            pruebaPatronComposite();
            pruebaPatronCommand();
            pruebaPatronDecoratorYFactoryMethod();
            pruebaPatronTemplateMethod();
            pruebaPatronBuilder();
            pruebaPatronIterator();
            pruebaPatronChainOfResponsability();
            pruebaPatronAdapter();
            pruebaPatronAbstractFactory();
            pruebaPatronSingleton();
            PruebaPatronProxy();
            pruebaPatronState();

            Console.ReadKey();


        }

        //*********************************************************************************************************************
        public static void pruebaPatronStrategy()
        {
            //ESTRATEGIA DE APAGADO DE INCENDIO (PUEDEN SER APAGADO POR ESCALERA - SECUENCIAL - ESPIRAL)
            IEstrategy estrategia = new Escalera();
            //SE LA PASA POR PARAMETRO AL CONSTRUCTOR DE LA CLASE BOMBERO LA ESTRATEGIA
            Bombero objBombero = new Bombero(estrategia);

            //SE CREAN LAS INSTANCIAS DE UNA CALLE Y DE UN LUGAR

            Plaza objPlaza = new Plaza(new ConstructorSimple());
            
            //SE SETEA EL CAUDAL DE AGUA
            objPlaza.SetSuperficieMetrosCuadrados(16);
            

            Calle objCalle = new Calle();
            objCalle.SetCaudalAguaPorMinuto(50);

            //SE LLAMA AL METODO APAGARINCENDIO() DEL BOMBERO Y SE LE PASA POR PARAMETRO LA CALLE Y EL LUGAR
            objBombero.ApagarIncendio(objPlaza , objCalle);
        }

        //*********************************************************************************************************************
        public static void pruebaPatronObserver()
        {
            //INSTANCIA DE BOMBERO QUE SERA AGREGADO COMO OBSERVADOR DE LAS PLAZAS Y CASAS
            Bombero objBombero1 = new Bombero(new Espiral());

            //INSTANCIA DE CALLE EN COMUN A TODOS LOS LUGARES (PLAZA Y CASAS)
            Calle objCalle = new Calle();
            //SE SETEA EL CAUDAL DE AGUA 
            objCalle.SetCaudalAguaPorMinuto(50);        


            //INSTANCIAS DE PLAZA Y CASAS
            Plaza objPlaza = new Plaza(objCalle, 4, new ConstructorSimple());            
            Casa objCasa1 = new Casa(objCalle, 9);
            Casa objCasa2 = new Casa(objCalle, 9);
            Casa objCasa3 = new Casa(objCalle, 9);
            Casa objCasa4 = new Casa(objCalle, 9);
            Casa objCasa5 = new Casa(objCalle, 9);

            //AGREGANDO BOMBERO OBSERVADOR A LA PLAZA
            objPlaza.AgregarObservador(objBombero1);
            //AGREGANDO BOMBERO OBSERVADOR A LAS CASAS Y CAMBIO DE ESTRATEGIA DE APAGADO DE INCENDIO A ESCALERA
            objBombero1.setEstrategia(new Escalera());
            objCasa1.AgregarObservador(objBombero1);
            objCasa2.AgregarObservador(objBombero1);
            objCasa3.AgregarObservador(objBombero1);
            objCasa4.AgregarObservador(objBombero1);
            objCasa5.AgregarObservador(objBombero1);

            //CAMBIO DE ESTADO EN LA PLAZA Y CASAS (SUENA LA ALARMA), NOTIFICA AL BOMBERO OBSERVADOR PARA QUE APAGUE EL INCENDIO
            objPlaza.Chispa();
            objCasa1.Chispa();
            objCasa2.Chispa();
            objCasa3.Chispa();
            objCasa4.Chispa();
            objCasa5.Chispa();
        }

        //*********************************************************************************************************************

        public static void pruebaPatronComposite()
        {
            // IMPLEMENTA LA INTERFACE COMPONENTE, ES LA CLASE COMPUESTO QUE CONTIENE COMPONENTES HOJAS (CALLES, ESQUINAS Y PLAZAS) CONFORMANDO UNA MANZANA
            CompuestoManzana manzana1 = new CompuestoManzana();
            CompuestoManzana manzana2 = new CompuestoManzana();

            for(int i = 0; i < 4; i++)
            {
                Calle objCalle1 = new Calle();             
                Esquina objEsquina1 = new Esquina();
                //SE AGREGAN LAS INSTANCIAS DE CALLES Y ESQUINAS A LA LISTAS DE COMPUESTOS MANZANAS
                manzana1.Agregar(objCalle1);
                manzana1.Agregar(objEsquina1);
                manzana2.Agregar(objCalle1);
                manzana2.Agregar(objEsquina1);
            }

            Plaza objPlaza1 = new Plaza();
            Plaza objPlaza2 = new Plaza();

            //SE AGREGAN LAS PLAZAS A LAS MANZANAS
            manzana1.Agregar(objPlaza1);
            manzana1.Agregar(objPlaza2);
            manzana2.Agregar(objPlaza1);
            manzana2.Agregar(objPlaza2);

            //SE CREA UN COMPUESTO CIUDAD QUE ALMACENA DOS MANZANAS           
            CompuestoCiudad objCiudad = new CompuestoCiudad();
            objCiudad.Agregar(manzana1);
            objCiudad.Agregar(manzana2);

            Electricista objElectricista = new Electricista();
            objElectricista.RevisarIluminable(objCiudad);
        }

        //*********************************************************************************************************************

        //EN ESTA PRUEBA HAY VARIOS PATRONES QUE TRABAJAN EN CONJUNTAMENTE : BUILDER, FACTORY METHOD, DECORATOR, STRATEGY
        public static void pruebaPatronDecoratorYFactoryMethod()
        {            
            //PRUEBA DE PATRON DECORATOR EN CONJUNTO CON EL PATRON FACTORY METHOD, AL MOMENTO DE ASIGNAR SECTORES EN LA MATRIZ, SE EVALUA SI PUEDE TENER DECORADOS

            IEstrategy estrategia = new Escalera();            
            Bombero objBombero = new Bombero(estrategia);

            //CALLE CON CAUDAL DE AGUA PARA APAGAR EL INCENDIO
            Calle objCalle = new Calle();

            //EN LA CLASE PLAZA, SE ENCARGA DE CREAR UNA MATRIZ DE SECTORES Y DECORARLOS SEGUN SU PROBABILIDAD

            ConstructorDesfaborable objConstructor = new ConstructorDesfaborable();
            objConstructor.setTemperatura(30);
            objConstructor.setViento(50);
            objConstructor.setCantidadPersonas(20);

            //PASANDOLE EL CONSTRUCTOR CONCRETO DEL PATRON BUILDER
            Plaza objPlaza = new Plaza(objConstructor);

            objPlaza.SetSuperficieMetrosCuadrados(9);
            objCalle.SetCaudalAguaPorMinuto(50);

            //SE LLAMA AL METODO APAGARINCENDIO() DEL BOMBERO Y SE LE PASA POR PARAMETRO LA CALLE Y EL LUGAR
            objBombero.ApagarIncendio(objPlaza, objCalle);
        }

        //*********************************************************************************************************************

        public static void pruebaPatronCommand()
        {
            //INSTANCIA DE POLICIA
            Policia objPolicia = new Policia();

            //LISTA DE PATRULLABLES
            List<IPatrullable> patrullables = new List<IPatrullable>();

            //CARGA DE IPATRULLABLES A LA LISTA 
            for (int i = 0; i < 15; i++)
            {
                IPatrullable IPatrullable = new Plaza();
                patrullables.Add(IPatrullable);
            }

            //RECORRER PATRULLABLES 
            int intContador = 0;

            foreach (IPatrullable item in patrullables)
            {
                if (intContador < 5)
                {
                    Iorden orden = new OrdenVozdeAlto();
                    objPolicia.setOrdenPolicial(orden);
                    objPolicia.PatrullarCallesCommand(item);
                    intContador++;
                }

                else if (intContador >= 5 && intContador < 10)
                {
                    Iorden orden = new OrdenPerseguirDelincuente();
                    objPolicia.setOrdenPolicial(orden);
                    objPolicia.PatrullarCallesCommand(item);
                    intContador++;
                }

                else if (intContador >= 10)
                {
                    Iorden orden = new OrdenPedirRefuerzos();
                    objPolicia.setOrdenPolicial(orden);
                    objPolicia.PatrullarCallesCommand(item);
                    intContador++;
                }
            }       
        }

        //*********************************************************************************************************************

        public static void pruebaPatronTemplateMethod()
        {            
           Medico objMedico = new Medico();
           objMedico.setProtocolo(new ProtocoloA());

           IInfartable transeunte = new Transeunte();
           objMedico.AtenderInfartoTemplateMethod(transeunte);           
        }


        //*********************************************************************************************************************

        public static void pruebaPatronAdapter()
        {                  
            Medico objMedico = new Medico();
            objMedico.setProtocolo(new ProtocoloA());
            objMedico.setVehiculo(new Ambulancia());
            Passerby objPasserby = new Passerby(0.5,0.5,0.6);
            IInfartable infartable = new IInfartableAdapter(objPasserby);
            objMedico.AtenderInfarto(infartable);            
        }

        //*********************************************************************************************************************

        public static void pruebaPatronBuilder()
        {             
            //CONSTRUCTOR CONCRETO DESFAVORABLE DE BUILDER 
            ConstructorDesfaborable constructor1 = new ConstructorDesfaborable();
            constructor1.setCantidadPersonas(5);
            constructor1.setTemperatura(40);
            constructor1.setViento(90);

            //CONSTRUCTOR CONCRETO FAVORABLE DE BUILDER
            ConstructorFavorable constructor2 = new ConstructorFavorable();
            constructor2.setIntLluvia(15);
        
            //CONSTRUCTOR CONCRETO MIXTO DE BUILDER
            ConstructorMixto constructor3 = new ConstructorMixto();
            constructor3.setLluvia(15);

            //CONSTRUCTOR CONCRETO SIMPLE
            ConstructorSimple constructor4 = new ConstructorSimple();

            //ASIGNANADO UN CONSTRUCTOR CONCRETO Y UN DIRECTOR A CADA INSTANCIA DE PLAZA

            Plaza objPlaza1 = new Plaza(constructor1);
            objPlaza1.SetSuperficieMetrosCuadrados(9);

            Plaza objPlaza2 = new Plaza(constructor2);
            objPlaza2.SetSuperficieMetrosCuadrados(9);

            Plaza objPlaza3 = new Plaza(constructor3);
            objPlaza3.SetSuperficieMetrosCuadrados(9);

            Plaza objPlaza4 = new Plaza(constructor4);
            objPlaza4.SetSuperficieMetrosCuadrados(9);

            //INSTANCIA DE CALLE CON SU CAUDAL DE AGUA DISPONIBLE
            Calle objCalle = new Calle(50);

            //INSTANCIA DE BOMBERO, SETEANDOLE UNA ESTRATEGIA DE APAGADO  
            Bombero objBombero = new Bombero(new Secuencial());

            Console.WriteLine("APAGANDO INCENDIO CON CIRCUNSTANCIAS DESFABORABLES");
            objBombero.ApagarIncendio(objPlaza1, objCalle);
            Console.WriteLine();

            Console.WriteLine("APAGANDO INCENDIO CON CIRCUNSTANCIAS FABORABLES");
            objBombero.ApagarIncendio(objPlaza2, objCalle);
            Console.WriteLine();

            Console.WriteLine("APAGANDO INCENDIO CON CIRCUNSTANCIAS MIXTAS");
            objBombero.ApagarIncendio(objPlaza3, objCalle);
            Console.WriteLine();

            Console.WriteLine("APAGANDO INCENDIO CON CIRCUNSTANCIAS NORMALES");
            objBombero.ApagarIncendio(objPlaza4, objCalle);
            Console.WriteLine();
        }

        //*********************************************************************************************************************

        public static void pruebaPatronIterator()
        {            
            //ESTRATEGIA DE APAGADO, UN BOMBERO Y UN SECRETARIO QUE RECIBE LA DENUNCIA PARA ASIGNARSELA A UN BOMBERO

            IEstrategy estrategia = new Escalera();
            Bombero objBombero = new Bombero(estrategia);
            objBombero.setVehiculo(new Ambulancia());
            objBombero.setHerramienta(new Manguera());

            BomberoSecretario secretario = new BomberoSecretario(objBombero);


            //INSTANCIAS DE CALLES (SE LE PASA POR PARAMETRO EL CAUDAL DE AGUA DISPONIBLE)
            Calle calle1 = new Calle(50);
            Calle calle2 = new Calle(50);
            Calle calle3 = new Calle(50);
            Calle calle4 = new Calle(50);
            Calle calle5 = new Calle(50);
            Calle calle6 = new Calle(50);

            // INSTANCIAS DE LUGARES
            ILugar A = new Plaza();           
            ILugar B = new Plaza(calle1, 9, new ConstructorSimple());
            ILugar C = new Plaza();
            ILugar D = new Plaza();
            ILugar E = new Plaza();
            ILugar F = new Plaza(calle2, 9, new ConstructorSimple());
            ILugar G = new Plaza( 9, new ConstructorSimple());
            ILugar H = new Plaza( 9, new ConstructorSimple());
            ILugar I = new Plaza( 9, new ConstructorSimple());
            ILugar J = new Plaza( 9, new ConstructorSimple());


            //"COMPROBACION DEL PATRON ITERATOR CON DENUNCIASPORTABLERO"

            //SE AGREGA A LA LISTA DE OBSERVADORES LA DENUNCIATABLERO EN LOS RESPECTIVOS ILUGARES

            DenunciasPorTablero denuncia1 = new DenunciasPorTablero();
            A.AgregarObservador(denuncia1);
            B.AgregarObservador(denuncia1);
            C.AgregarObservador(denuncia1);
            D.AgregarObservador(denuncia1);
            E.AgregarObservador(denuncia1);
            F.AgregarObservador(denuncia1);

            //SE INVOCA EL METODO CHISPA() DE LOS LUGARES B Y F, ESTE PROVOCA EL CAMBIO DE ESTADO Y NOTIFICA AL OBSERVADOR(LA DENUNCIA POR TABLERO)
            B.Chispa();
            F.Chispa();

            //SE INVOCA AL METODO ATENDERDENUNCIAS() DEL SECRETARIO EL CUAL RECIBE 
            //LA DENUNCIA Y CONSTRUYE UN ITERADOR PARA QUE ESTE ITERE CADA DENUNCIA

            secretario.atenderDenuncias(denuncia1);

        
            //COMPROBACION DEL PATRON ITERATOR CON DENUNCIASPORWHATSAPP

            //CREACION DE LISTA ENLAZADA

            //REFERENCIA DE TIPO MensajeWhatsapp QUE NO CONTIENE NADA
            MensajeWhatsapp listadenunciaWhatsapp = null;

            //SE LE ASIGANA UN OBJETO DE TIPO MensajeWhatsapp A TAL REFERENCIA
            //LAS DENUNCIAS RECIBEN LAS CALLES Y LOS LUGARES POR CONSTRUCTOR PARA EL METODO APAGAR INCENDIO DEL BOMBERO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(G, calle3), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(H, calle4), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(I, calle5), listadenunciaWhatsapp);

            //INSTANCIA DE DENUNCIAPORWHATSAPP A LA CUAL SE LE PASA POR PARAMETRO UNA LISTA ENLAZADA
            DenunciasPorWhatsapp denuncia2 = new DenunciasPorWhatsapp(listadenunciaWhatsapp);
            secretario.atenderDenuncias(denuncia2);

            //COMPROBACION DEL PATRON ITERATOR CON DENUNCIASPORMOSTRADOR

            DenunciasPorMostrador denuncia3 = new DenunciasPorMostrador(new DenunciaDeIncendio(J,calle6));
            secretario.atenderDenuncias(denuncia3);            
        }


        //*********************************************************************************************************************

        
        public static void pruebaPatronChainOfResponsability()
        {
            //PATRON CHAIN OF RESPONSABILITY


            //INSTANCIAS DE CALLES (SE LE PASA POR PARAMETRO EL CAUDAL DE AGUA DISPONIBLE)          
            Calle calle3 = new Calle(50);
            Calle calle4 = new Calle(50);
            Calle calle5 = new Calle(50);

            //INSTANCIAS DE LUGARES       
            ILugar G = new Plaza(9, new ConstructorSimple());
            ILugar H = new Plaza(9, new ConstructorSimple());

            ConstructorDesfaborable constructorConcreto = new ConstructorDesfaborable();
            constructorConcreto.setCantidadPersonas(3);
            constructorConcreto.setTemperatura(30);
            constructorConcreto.setViento(50);
            ILugar I = new Plaza(9, constructorConcreto);
            
            //PATRON ITERATOR CON DENUNCIASPORWHATSAPP

            //CREACION DE LISTA ENLAZADA

            //REFERENCIA DE TIPO MensajeWhatsapp QUE NO CONTIENE NADA
            MensajeWhatsapp listadenunciaWhatsapp = null;

            //DENUNCIAS DE INCENDIO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(G, calle3), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(H, calle4), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(I, calle5), listadenunciaWhatsapp);

            //DENUNCIAS NUEVAS DE LA CONSIGNA NUMERO 12 (CHAIN OF RESPONSABILITY)

            //DOS DENUNCIAS DE INFARTOS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(new Transeunte()), listadenunciaWhatsapp);
            Passerby objPasserby = new Passerby(1.2, 1.2, 1.2);
            IInfartable infartable = new IInfartableAdapter(objPasserby);      
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(infartable), listadenunciaWhatsapp);

            //TRES DENUNCIAS POR ROBO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);

            //CINCO DENUNCIAS POR LAMPARAS QUEMADAS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);

            //INSTANCIA DE DENUNCIAPORWHATSAPP A LA CUAL SE LE PASA POR PARAMETRO UNA LISTA ENLAZADA
            DenunciasPorWhatsapp denuncia2 = new DenunciasPorWhatsapp(listadenunciaWhatsapp);


            //CADENA DE HEROES

            Manejador m = new Bombero(null, new Escalera(), new Manguera(), new Autobomba());

            m = new Policia(m, new OrdenVozdeAlto(), new Pistola(), new Patrullero());

            m = new Medico(m, new ProtocoloA(), new Desfibrilador(), new Ambulancia());

            m = new Electricista(m, new Buscapolo(), new Camioneta());

     
            //SE LE PASA COMO PARAMETRO UNA CADENA DE MANEJADORES AL OPERADOR
            Operador911 objOperador = new Operador911(m);
            objOperador.atenderDenuncias(denuncia2);
        }

        public static void pruebaPatronAbstractFactory()
        {             
            //CREANDO LAS FABRICAS CONCRETAS DE CADA HEROE

            IFabricaDeHeroes fabricaPolicias = new FabricaDePolicias();
            IFabricaDeHeroes fabricaBomberos = new FabricaDeBomberos();
            IFabricaDeHeroes fabricaElectricista = new FabricaDeElectricistas();
            IFabricaDeHeroes fabricaMedicos = new FabricaDeMedicos();

            //INVOCANDO AL METODO DE CLASE ESTATICO CREARHEROE QUE RECIBE UNA FABRICA Y SE ENCARGA DE CREAR
            //EL HEROE, EL VEHICULO Y LA HERRAMIENTA PARA ALMACENARLO EN UN CUARTEL Y RETORNAR EL IRESPONSABLE

            //CREANDO CUARTEL
            ICuartel cuartelPolicias = crearHeroe(fabricaPolicias);
            //LE SOLICITAMOS EL IRESPONSABLE(RESPONSABLE CON SU VEHICULO Y HERRAMIENTA) AL CUARTEL
            Policia policiaResponsable = (Policia) cuartelPolicias.getPersonal();
            policiaResponsable.setOrdenPolicial(new OrdenPerseguirDelincuente());
            policiaResponsable.PatrullarCalles(new Plaza());
            Console.WriteLine();
            
            ICuartel cuartelBomberos = crearHeroe(fabricaBomberos);
            Bombero bomberoResponsable = (Bombero)cuartelBomberos.getPersonal();
            bomberoResponsable.setEstrategia(new Escalera());
            bomberoResponsable.ApagarIncendio2(new Plaza(9, new ConstructorSimple()),new Calle(50));
            Console.WriteLine();
            
            ICuartel cuartelElectricista = crearHeroe(fabricaElectricista);
            Electricista electricistaResponsable = (Electricista)cuartelElectricista.getPersonal();
            Plaza objPlaza = new Plaza();
            objPlaza.SetCantidadFarolas(10);
            electricistaResponsable.Revisar(objPlaza);
            Console.WriteLine();
            
            ICuartel cuartelMedicos = crearHeroe(fabricaMedicos);
            Medico medicoResponsable = (Medico)cuartelMedicos.getPersonal();
            medicoResponsable.setProtocolo(new ProtocoloB());
            medicoResponsable.AtenderInfarto(new Transeunte());
            Console.WriteLine();            
        }

        //METODO PARA CREAR UN CUARTEL PARA EL PATRON ABSTRACT FACTORY
        public static ICuartel crearHeroe(IFabricaDeHeroes fabrica)
        {
            ICuartel cuartel = fabrica.crearCuartel();
            IResponsable responsable = fabrica.crearHeroe();
            IVehiculo vehiculo = fabrica.crearVehiculo();
            IHerramienta herramienta = fabrica.crearHerramienta();

            cuartel.agregarHerramienta(herramienta);
            cuartel.agregarPersonal(responsable);
            cuartel.agregarVehiculo(vehiculo);

            return cuartel;
        }

        //*********************************************************************************************************************

        public static void pruebaPatronSingleton()
        {

            //CREACION DE FABRICA DE CADA HEROE CON SU VEHICULOS Y HERRAMIENTA

            FabricaDeBomberos objFabricaBombero = new FabricaDeBomberos();
            IResponsable bomberoResponsable = objFabricaBombero.crearHeroe();
            IVehiculo vehiculoBombero = objFabricaBombero.crearVehiculo();
            IHerramienta herramientaBombero = objFabricaBombero.crearHerramienta();

            FabricaDeElectricistas objFabricaElectricista = new FabricaDeElectricistas();
            IResponsable electricistaResponsable = objFabricaElectricista.crearHeroe();
            IVehiculo vehiculoElectricista = objFabricaElectricista.crearVehiculo();
            IHerramienta herramientaElectrica = objFabricaElectricista.crearHerramienta();

            FabricaDePolicias objFabricaPolicia = new FabricaDePolicias();
            IResponsable policiaResponsable = objFabricaPolicia.crearHeroe();
            IVehiculo vehiculoPolicial = objFabricaPolicia.crearVehiculo();
            IHerramienta herramientaPolicial = objFabricaPolicia.crearHerramienta();

            FabricaDeMedicos objFabricaMedico = new FabricaDeMedicos();
            IResponsable medicoResponsable = objFabricaMedico.crearHeroe();
            IVehiculo vehiculoMedico = objFabricaMedico.crearVehiculo();
            IHerramienta herramientaMedica = objFabricaMedico.crearHerramienta();


            //CREACION DE CUARTELES DE LOS HEROES Y SE AGREGA SU PERSONAL RESPONSABLE CORRESPONDIENTE CON SU HERRAMIENTA Y VEHICULO

            //USO DEL METODO ESTATICO DEL PATRON SINGLETON PARA CREAR UNA SOLA INSTANCIA DEL CUARTEL
            CuartelDeBomberos cuartelBomberos = CuartelDeBomberos.getCuartelBombero();
            cuartelBomberos.agregarPersonal(bomberoResponsable);
            cuartelBomberos.agregarVehiculo(vehiculoBombero);
            cuartelBomberos.agregarHerramienta(herramientaBombero);

            //USO DEL METODO ESTATICO DEL PATRON SINGLETON PARA CREAR UNA SOLA INSTANCIA DEL CUARTEL
            CentralElectrica central = CentralElectrica.getCuartelElectricista();
            central.agregarPersonal(electricistaResponsable);
            central.agregarVehiculo(vehiculoElectricista);
            central.agregarHerramienta(herramientaElectrica);

            //USO DEL METODO ESTATICO DEL PATRON SINGLETON PARA CREAR UNA SOLA INSTANCIA DEL CUARTEL
            Comisaria cuartelDePolicia = Comisaria.getCuartelPolicia();
            cuartelDePolicia.agregarPersonal(policiaResponsable);
            cuartelDePolicia.agregarVehiculo(vehiculoPolicial);
            cuartelDePolicia.agregarHerramienta(herramientaPolicial);

            //USO DEL METODO ESTATICO DEL PATRON SINGLETON PARA CREAR UNA SOLA INSTANCIA DEL CUARTEL
            Hospital hospital = Hospital.getHospital();
            hospital.agregarPersonal(medicoResponsable);
            hospital.agregarVehiculo(vehiculoMedico);
            hospital.agregarHerramienta(herramientaMedica);

            //LE SOLICITAMOS A LOS CUARTES CREADOS, LOS HEROES AGREGADOS ANTERIORMENTE Y PROCEDEMOS A LLAMAR SUS METODOS DE ACCION
            
            IResponsable b1 = cuartelBomberos.getPersonal();
            Bombero bombero = (Bombero)b1;
            bombero.setEstrategia(new Escalera());                        
            bombero.ApagarIncendio2(new Plaza(9, new ConstructorSimple()), new Calle(50));
            Console.WriteLine();

            IResponsable b3 = central.getPersonal();
            b3.Revisar(new Plaza());            
            Console.WriteLine();

            IResponsable b2 = cuartelDePolicia.getPersonal();
            Policia policia = (Policia)b2;
            policia.setOrdenPolicial(new OrdenVozdeAlto());
            policia.PatrullarCalles(new Plaza());
            Console.WriteLine();

            IResponsable b4 = hospital.getPersonal();
            Medico medico = (Medico)b4;            
            medico.setProtocolo(new ProtocoloA());
            medico.AtenderInfarto(new Transeunte());
            Console.WriteLine();
        }

        //*********************************************************************************************************************


        public static void PruebaPatronProxy()
        {          
            //INSTANCIAS DE CALLES (SE LE PASA POR PARAMETRO EL CAUDAL DE AGUA DISPONIBLE)          
            Calle calle3 = new Calle(50);
            Calle calle4 = new Calle(50);
            Calle calle5 = new Calle(50);

            //INSTANCIAS DE LUGARES       
            ILugar G = new Plaza(9, new ConstructorSimple());
            ILugar H = new Plaza(9, new ConstructorSimple());
            ILugar I = new Plaza(9, new ConstructorSimple());

            //PATRON ITERATOR CON DENUNCIASPORWHATSAPP

            //CREACION DE LISTA ENLAZADA

            //REFERENCIA DE TIPO MensajeWhatsapp QUE NO CONTIENE NADA
            MensajeWhatsapp listadenunciaWhatsapp = null;

            //DENUNCIAS DE INCENDIO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(G, calle3), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(H, calle4), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(I, calle5), listadenunciaWhatsapp);

            //DENUNCIAS NUEVAS DE LA CONSIGNA NUMERO 12 (CHAIN OF RESPONSABILITY)

            //DOS DENUNCIAS DE INFARTOS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(new Transeunte()), listadenunciaWhatsapp);

            Passerby objPasserby = new Passerby(1.2, 1.2, 1.2);
            IInfartable infartable = new IInfartableAdapter(objPasserby);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(infartable), listadenunciaWhatsapp);

            //TRES DENUNCIAS POR ROBO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);

            //CINCO DENUNCIAS POR LAMPARAS QUEMADAS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);

            //INSTANCIA DE DENUNCIAPORWHATSAPP A LA CUAL SE LE PASA POR PARAMETRO UNA LISTA ENLAZADA
            DenunciasPorWhatsapp denuncia2 = new DenunciasPorWhatsapp(listadenunciaWhatsapp);


            //FABRICA PARA EL ESTADO DE BOMBERO PROXY PARA QUE PUEDA CREAR AL BOMBERO REAL
            FabricaDeBomberos fabrica = new FabricaDeBomberos();

            //PATRON PROXY PRUEBA

            //UN BOMBERO PROXY ES UN MANEJADOR, ESTE TIENE EN SU ESTADO UNA IFABRICADEHEROES QUE ES USADA PARA CREAR AL BOMBERO REAL A
            //LA HORA DE INVOCAR EL METODO APAGAR INCENDIO

            //CADENA DE RESPONSABILIDADES 
            Manejador m = new BomberoProxy(null, fabrica);

            m = new Policia(m, new OrdenVozdeAlto(), new Pistola(), new Patrullero());

            m = new Medico(m, new ProtocoloA(), new Desfibrilador(), new Ambulancia());

            m = new Electricista(m, new Buscapolo(), new Camioneta());


            //SE LE PASA COMO PARAMETRO UNA CADENA DE MANEJADORES AL OPERADOR
            Operador911 objOperador = new Operador911(m);
            objOperador.atenderDenuncias(denuncia2);
        }

        //*********************************************************************************************************************


        public static void pruebaPatronState()
        {
            //PATRON STATE (EL HEROE VA A REALIZAR SU TAREA SI EL VEHICULO NO SE ROMPE EN EL TRAYECTO (METODO CONDUCIR))

            //INSTANCIAS DE CALLES (SE LE PASA POR PARAMETRO EL CAUDAL DE AGUA DISPONIBLE)          
            Calle calle3 = new Calle(50);
            Calle calle4 = new Calle(50);
            Calle calle5 = new Calle(50);

            //INSTANCIAS DE LUGARES       
            ILugar G = new Plaza(9, new ConstructorSimple());
            ILugar H = new Plaza(9, new ConstructorSimple());
            ILugar I = new Plaza(9, new ConstructorSimple());

            //PATRON ITERATOR CON DENUNCIASPORWHATSAPP

            //CREACION DE LISTA ENLAZADA

            //REFERENCIA DE TIPO MensajeWhatsapp QUE NO CONTIENE NADA
            MensajeWhatsapp listadenunciaWhatsapp = null;

            //DENUNCIAS DE INCENDIO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(G, calle3), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(H, calle4), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeIncendio(I, calle5), listadenunciaWhatsapp);

            //DENUNCIAS NUEVAS DE LA CONSIGNA NUMERO 12 (CHAIN OF RESPONSABILITY)

            //DOS DENUNCIAS DE INFARTOS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(new Transeunte()), listadenunciaWhatsapp);

            Passerby objPasserby = new Passerby(1.2, 1.2, 1.2);
            IInfartable infartable = new IInfartableAdapter(objPasserby);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeInfarto(infartable), listadenunciaWhatsapp);

            //TRES DENUNCIAS POR ROBO
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeRobo(new Plaza()), listadenunciaWhatsapp);

            //CINCO DENUNCIAS POR LAMPARAS QUEMADAS
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);
            listadenunciaWhatsapp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Plaza()), listadenunciaWhatsapp);

            //INSTANCIA DE DENUNCIAPORWHATSAPP A LA CUAL SE LE PASA POR PARAMETRO UNA LISTA ENLAZADA
            DenunciasPorWhatsapp denuncia2 = new DenunciasPorWhatsapp(listadenunciaWhatsapp);


            //CADENA DE HEROES

            Manejador m = new Bombero(null, new Escalera(), new Manguera(), new Autobomba());

            m = new Policia(m, new OrdenVozdeAlto(), new Pistola(), new Patrullero());

            m = new Medico(m, new ProtocoloA(), new Desfibrilador(), new Ambulancia());

            m = new Electricista(m, new Buscapolo(), new Camioneta());


            //SE LE PASA COMO PARAMETRO UNA CADENA DE MANEJADORES AL OPERADOR 
            //ESTOS HEROES REALIZARAN SU TAREA SI EL VEHICULO NO SE ROMPIO POR EL CAMINIO
            Operador911 objOperador = new Operador911(m);
            objOperador.atenderDenuncias(denuncia2);
        }


    }
}
