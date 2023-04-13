namespace ExamenFinal
{
    class Menu
    {
        private int opcion;
        private List<Conductor>? listaConductor;
        private List<Vehiculo>? lisVehiculo;
        private List<TipoInfraccion>? lisInfra;
        private List<Agente>? lisAgente;
        private List<TipoLicencia> listLicencia;
    
        public void desplegar()
        {
            listaConductor = new List<Conductor>();
            lisVehiculo = new List<Vehiculo>();
            lisInfra = new List<TipoInfraccion>();
            lisAgente = new List<Agente>();
            listLicencia = new List<TipoLicencia>();
            do
            {
                do{
                    Console.WriteLine("Bienvenido al sistema de multas: Elija una opcion");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("1. Registrar una multa.");
                    Console.WriteLine("2. Consultar una multa.");
                    Console.WriteLine("3. Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion < 1 || opcion > 3){
                        Console.WriteLine("Ingrese una opcion valida de 1 al 3");
                    }

                }
                while(opcion < 1 || opcion > 3);

                switch (opcion)
                {
                    case 1:
                    {
                        /*Registro de multas*/
                        Conductor infractorNuevo = new Conductor();
                        Vehiculo carroNuevo = new Vehiculo();
                        TipoInfraccion infra = new TipoInfraccion();
                        Agente agenteNuevo = new Agente();
                        TipoLicencia licenNueva = new TipoLicencia();
                        
                        Console.WriteLine("DATOS DEL CONDUCTOR ");
                        Console.WriteLine("----------------------------------  ");
                        Console.WriteLine("Nombre del conductor:  ");
                        infractorNuevo.NombreCon = Convert.ToString(Console.ReadLine());

                        Console.Write("Cedula del conductor: ");
                        infractorNuevo.CedulaCon = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Direccion del conductor:");
                        infractorNuevo.DireccionCon = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Ingrese su fecha de nacimiento: ");
                        infractorNuevo.FechaCon = Convert.ToString(Console.ReadLine());
                        listaConductor.Add(infractorNuevo);

                        Console.WriteLine("Elija el tipo de licencia: ");
                        Console.WriteLine("1.Todo tipo de vehiculo");
                        Console.WriteLine("2.vehiculos Pesados");
                        Console.WriteLine("3.Motocicletas");
                            int licencia = int.Parse(Console.ReadLine());
                            switch (licencia) {
                                case 1:
                                    licenNueva.claLicencia = "Todo tipo de vehiculo";                           
                                break;
                                case 2:
                                    licenNueva.claLicencia = "";
                                break;
                                case 3:
                                    licenNueva.claLicencia = "";
                                break;
                    
                            }
                        Console.WriteLine("DATOS DEL VEHICULO: ");
                        listLicencia.Add(licenNueva);

                        Console.WriteLine("Placa: ");
                        carroNuevo.placa = Console.ReadLine();

                        Console.WriteLine("Marca: ");
                        carroNuevo.marca = Console.ReadLine();

                        Console.WriteLine("Modelo: ");
                        carroNuevo.modelo = Console.ReadLine();

                        Console.WriteLine("Color: ");
                        carroNuevo.Color = Console.ReadLine();

                        Console.WriteLine("Año: ");
                        carroNuevo.Año = Console.ReadLine();

                        Console.WriteLine("Numero de chasis: ");
                        carroNuevo.chasis = Console.ReadLine();

                        lisVehiculo.Add(carroNuevo);

                        Console.WriteLine("Ingrese el tipo de infraccion: " );
                        Console.WriteLine("1. Obstruccion de transito");
                        Console.WriteLine("2. Pase Semaforo en rojo");
                        Console.WriteLine("3.  Hablar por celular");
                        Console.WriteLine("4.  Conducir sin cinturon");
                        Console.WriteLine("5. Licencia vencida");  


                         int infraccion = int.Parse(Console.ReadLine());
                        switch(infraccion){
                            case 1:
                                infra.nombreInfraccion = " Obstruccion de transito";
                                break;
                            case 2: 
                                infra.nombreInfraccion = "Pase Semaforo en rojo";
                                 break;
                            case 3:
                                infra.nombreInfraccion = "Hablar por celular";
                                 break;
                            case 4:
                                 infra.nombreInfraccion = "Conducir sin cinturon";
                                break;
                            case 5:
                                infra.nombreInfraccion = "Licencia vencida";
                            break;
                        } 
                            lisInfra.Add(infra);


                        Console.WriteLine("DATOS DEL AGENTE DE TRANSITO ");
                        Console.WriteLine("----------------------------------  ");
                        Console.WriteLine("Nombre: ");
                        agenteNuevo.nombreCompleto = Console.ReadLine();

                        Console.WriteLine("Codigo de empleado ");
                        agenteNuevo.Codigo_Empleado = Console.ReadLine();

                        Console.WriteLine("Direccion:  ");
                        agenteNuevo.domicilio = Console.ReadLine();

                        Console.WriteLine("Fecha de Ingreso:  ");
                        agenteNuevo.FechaIgre = Console.ReadLine();

                        break;

                        lisAgente.Add(agenteNuevo);
                    }
                    

                    case 2:
                    {
                        /*Consulta de multas*/
                        foreach(Conductor b in listaConductor){
                            Console.WriteLine ("NOMBRE CONDUCTOR: " + b.NombreCon); 
                            Console.WriteLine ("CEDULA: "+ b.CedulaCon );
                            Console.WriteLine ("FECHA DE NACIMIENTO: "+ b.FechaCon);
                            Console.WriteLine ("DIRECCION:  " + b.DireccionCon);
                        }
                        foreach(Vehiculo b in lisVehiculo){
                            Console.WriteLine("PLACA: " + b.placa);
                            Console.WriteLine("MARCA: "+ b.marca);
                            Console.WriteLine("MODELO: " + b.modelo);
                            Console.WriteLine("CHASIS: " + b.chasis);
                            Console.WriteLine("COLOR: " + b.Color);
                            Console.WriteLine("AÑO VEHICULO" + b.Año);
                        }
                        foreach(TipoInfraccion b in lisInfra){
                            Console.WriteLine();
                        }
                        foreach(Agente b in lisAgente){
                            Console.WriteLine(b.Codigo_Empleado + b.nombreCompleto + b.domicilio);
                        }

                        break;
                    }
                    case 3:
                    { 
                        Console.WriteLine("Sistema de multas saliendo...");
                        Console.ReadKey();
                        /*Salir del sistema*/
                        break;
                    }
                }

            }
            while(opcion != 3);
        }
    }
}