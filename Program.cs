namespace TrabajoPractico6{
    class Program{
        static void Main(string[] args){
            int ejercicio;

            Console.Write("Seleccionar ejercicio 1 o 2: ");

            ejercicio = Int32.Parse(Console.ReadLine());

            if(ejercicio == 1) ejercicio_1();
            else ejercicio_2();
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
            
        }
    }

    class Calculadora{
        private double resultado;

        public Calculadora(double resultado){
            this.resultado = resultado;
        }

        public double GetResultado(){
            return this.resultado;
        }

        public void Sumar(double termino){
            this.resultado += termino;
        }

        public void Restar(double termino){
            this.resultado -= termino;
        }

        public void Multiplicar(double termino){
            this.resultado *= termino;
        }

        public void Dividir(double termino){
            if(termino != 0){
                this.resultado /= termino;
            }
        }

        public void Limpiar(double resultado){
            this.resultado = resultado;
        }

    }
}