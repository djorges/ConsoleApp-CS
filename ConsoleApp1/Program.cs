using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
        }
    }

    //Escribir una clase que permita ingresar las horas trabajadas y el pago por hora de un operario. Luego calcule el sueldo total.
    class Sueldo
    {
        static int Main(string[] args)
        {
            CalcularSueldo();
            return 0;
        }
        static void CalcularSueldo()
        {
            //CalculoSueldo
            int horasTrabajadas;
            string cadena;
            float sueldo;
            float costoHora;
            Console.WriteLine("Ingrese Horas trabajadas por el operario:");
            cadena = Console.ReadLine();
            horasTrabajadas = int.Parse(cadena);
            Console.WriteLine("Ingrese el pago por hora:");
            cadena = Console.ReadLine();
            costoHora = float.Parse(cadena);
            sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("El sueldo total del operario es:" + sueldo);
        }
    }

    //Escribir una clase que permita ingresar y luego mostrar nombre y edad de una persona, además de un método que determine si es o no mayor de edad.
    class Persona
    {
        private string nombre;
        private int edad;
        public void Inicializar()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
        }

        static void Main(string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }

    //Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
    class TablaMultiplicacion
    {
        static void Main(string[] args)
        {
            TablaMultiplicacion obj = new TablaMultiplicacion();
            obj.CargarValor();
        }
        private void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.WriteLine("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }
        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)// for (int i = 1; i<=10; i++)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }
    }
}
