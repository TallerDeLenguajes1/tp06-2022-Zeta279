namespace TrabajoPractico6
{
    class Program{
        static void Main(string[] args){
            Console.Write("Seleccionar ejercicio 1 o 2: ");

            switch(Console.ReadLine()){
                case "1":
                    ejercicio_1();
                    break;
                case "2":
                    ejercicio_2();
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        }

        static void ejercicio_1(){
            bool continuar = true;
            int opcion;
            double numero;

            Console.Write("Ingrese un resultado inicial: ");
            numero = Double.Parse(Console.ReadLine());

            Calculadora calc = new Calculadora(numero);

            while(continuar){
                Console.WriteLine("\nResultado actual: {0}", calc.GetResultado());
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Limpiar");
                Console.WriteLine("6) Salir");

                Console.Write("\nOpción: ");
                opcion = Int32.Parse(Console.ReadLine());

                switch(opcion){
                    case 1:
                        Console.Write("Ingrese un número para sumar: ");
                        numero = Double.Parse(Console.ReadLine());
                        calc.Sumar(numero);
                        break;
                    case 2:
                        Console.Write("Ingrese un número para restar: ");
                        numero = Double.Parse(Console.ReadLine());
                        calc.Restar(numero);
                        break;
                    case 3:
                        Console.Write("Ingrese un número para multiplicar: ");
                        numero = Double.Parse(Console.ReadLine());
                        calc.Multiplicar(numero);
                        break;
                    case 4:
                        Console.Write("Ingrese un número para dividir: ");
                        numero = Double.Parse(Console.ReadLine());
                        calc.Dividir(numero);
                        break;
                    case 5:
                        Console.Write("Ingresar un nuevo resultado: ");
                        numero = Double.Parse(Console.ReadLine());
                        calc.Limpiar(numero);
                        break;
                    case 6:
                        Console.Write("Saliendo del programa");
                        continuar = false;
                        break;
                }
            }
        }

        static void ejercicio_2(){
            Empleado[] empleados = new Empleado[3];
            string aux;
            int opcion, indice = 0;
            double salarioTotal = 0, jubilacion = 0;
            int dia, mes, anio;

            Console.WriteLine("Cargar datos para tres empleados");
            
            for(int i = 0; i < 3; i++)
            {
                empleados[i] = new Empleado();

                Console.WriteLine($"Empleado {i + 1}");
                Console.Write("Nombre: ");
                empleados[i].Nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                empleados[i].Apellido = Console.ReadLine();

                Console.WriteLine("Fecha de nacimiento: ");
                Console.Write("Año: ");
                do { anio = int.Parse(Console.ReadLine()); } while (anio <= 1920 || anio >= 2002);

                Console.Write("Mes: ");
                do { mes = int.Parse(Console.ReadLine()); } while (mes < 1 || mes > 12);

                Console.Write("Día: ");
                do { dia = int.Parse(Console.ReadLine()); } while (dia < 1 || dia > 31);

                empleados[i].FechaNac = new DateTime(anio, mes, dia);

                do
                {
                    Console.Write("Está casado? (S: Sí / N: No): ");
                    aux = Console.ReadLine().ToLower();

                    if (aux == "s")
                    {
                        empleados[i].EstadoCivil = 'C';
                    }
                    else if (aux == "n")
                    {
                        empleados[i].EstadoCivil = 'S';
                    }
                    else
                    {
                        Console.WriteLine("Opción incorrecta");
                    }
                } while (aux != "s" && aux != "n") ;


                do
                {
                    Console.Write("Género (H: Hombre / M: Mujer): ");
                    aux = Console.ReadLine().ToLower();

                    if (aux == "h")
                    {
                        empleados[i].Genero = 'H';
                    }
                    else if (aux == "m")
                    {
                        empleados[i].Genero = 'M';
                    }
                    else
                    {
                        Console.WriteLine("Opción incorrecta");
                    }

                } while (aux != "h" && aux != "m");

                Console.WriteLine("Fecha de ingreso en la empresa: ");
                Console.Write("Año: ");
                do { anio = int.Parse(Console.ReadLine()); } while (anio <= 1950 || anio >= 2022);

                Console.Write("Mes: ");
                do { mes = int.Parse(Console.ReadLine()); } while (mes < 1 || mes > 12);

                Console.Write("Día: ");
                do { dia = int.Parse(Console.ReadLine()); } while (dia < 1 || dia > 31);

                empleados[i].FechaIngreso = new DateTime(anio, mes, dia);

                Console.Write("Sueldo básico: ");
                empleados[i].SueldoBasico = int.Parse(Console.ReadLine());

                Console.WriteLine("Cargo");
                Console.WriteLine("Opciones válidas:");
                Console.WriteLine("1) Auxiliar");
                Console.WriteLine("2) Administrativo");
                Console.WriteLine("3) Ingeniero");
                Console.WriteLine("4) Especialista");
                Console.WriteLine("5) Investigador");

                do
                {
                    Console.Write("Opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            empleados[i].Cargo = Cargos.Auxiliar;
                            break;
                        case 2:
                            empleados[i].Cargo = Cargos.Administrativo;
                            break;
                        case 3:
                            empleados[i].Cargo = Cargos.Ingeniero;
                            break;
                        case 4:
                            empleados[i].Cargo = Cargos.Especialista;
                            break;
                        case 5:
                            empleados[i].Cargo = Cargos.Investigador;
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (opcion < 1 || opcion > 5);

                if(i == 0)
                {
                    jubilacion = empleados[i].Jubilacion();
                }
                else if (empleados[i].Jubilacion() < jubilacion)
                {
                    indice = i;
                    jubilacion = empleados[i].Jubilacion();
                }


                salarioTotal += empleados[i].Salario();
            }

            
            Console.WriteLine($"Salario total: {salarioTotal}");
            Console.WriteLine($"Empleado más proximo a jubilarse:\n{empleados[indice]}\n");
        }
    }
}