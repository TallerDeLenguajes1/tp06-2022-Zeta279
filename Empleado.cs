namespace TrabajoPractico6
{
    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public Empleado() { }

        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.EstadoCivil = estadoCivil;
            this.Genero = genero;
            this.FechaIngreso = fechaIngreso;
            this.SueldoBasico = sueldoBasico;
            this.Cargo = cargo;
        }

        public Cargos Cargo { get => cargo; set => cargo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public int Antiguedad(){
            return DateTime.Now.Year - this.FechaIngreso.Year;
        }

        public int Edad(){
            return DateTime.Now.Year - this.FechaNac.Year;
        }

        public int Jubilacion(){
            if(genero == 'H') return 65 - this.Antiguedad();
            else return 60 - this.Antiguedad();
        }

        public double Salario(){
            double adicional = 0;

            if(this.Antiguedad() < 20){
                adicional += this.sueldoBasico * (0.01 * this.Antiguedad());
            }
            else{
                adicional += this.sueldoBasico * 0.25;
            }

            if(this.cargo == Cargos.Ingeniero || this.cargo == Cargos.Especialista){
                adicional += adicional * 0.5;
            }

            if(this.estadoCivil == 'C')
            {
                adicional += 15000;
            }

            return this.sueldoBasico + adicional;
        }

        public override string ToString()
        {
            string cadena = new string("");

            cadena = $"Nombre: {this.nombre}\n";
            cadena += $"Apellido: {this.apellido}\n";
            cadena += $"Fecha de nacimiento: {this.fechaNac.ToString("dd/MM/yyyy")}\n";
            cadena += $"Estado Civil: ";

            if (this.estadoCivil == 'C') cadena += "Casado\n";
            else cadena += "Soltero\n";

            cadena += $"Fecha de ingreso en la empresa: {this.fechaIngreso.ToString("dd/MM/yyyy")}\n";
            cadena += $"Antiguedad: {this.Antiguedad()}\n";
            cadena += $"Sueldo b?sico: {this.sueldoBasico}\n";
            cadena += $"Salario completo: {this.Salario()}\n";
            cadena += $"Cargo: {this.cargo}\n";
            cadena += $"A?os restantes para la jubilaci?n: {this.Jubilacion()}";

            return cadena;
        }

    }
}