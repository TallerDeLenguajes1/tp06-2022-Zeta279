namespace TrabajoPractico6
{
    class Calculadora
    {
        private double resultado;

        public Calculadora(double numero){
            this.resultado = numero;
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

        public void Limpiar(double numero){
            this.resultado = numero;
        }

    }
}namespace TrabajoPractico6{
    
}