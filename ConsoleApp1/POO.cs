using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class POO
    {
        static void Main(string[] args) 
        {
        
        }
    }

    //(Clase):Plantear una clase llamada Alumno y definir como atributos su nombre y su edad. En el constructor realizar la carga de datos. Definir otros dos métodos para imprimir los datos ingresados y un mensaje si es mayor o no de edad (edad >=18)
    class Alumno
    {
        private string nombre; //Atributos
        private int edad;
        public Alumno() //Constructor 
        {
            Console.WriteLine("Ingrese nombre:");
            nombre = Console.ReadLine(); //Inicializar Atributos
            Console.WriteLine("Ingrese edad:");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }
        public void EsMayorEdad()
        {
            if (edad >= 18) Console.WriteLine(nombre + " es mayor de edad.");
            else Console.Write(nombre + " no es mayor de edad.");

        }
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.Imprimir();
            alumno.EsMayorEdad();
        }
    }
    //(Clase):Plantear una clase llamada Coche y definir como atributos ruedas, largo, ancho, climatizador, tapiceria. En el constructor inicializar ruedas, largo y ancho. Definir métodos para obtener la información del coche, establecer y mostrar extras(tapicería,climatizador).
    class Coche
    {
        private int ruedas;
        private double largo, ancho;
        private bool climatizador;
        private String tapiceria;
        public Coche(int paramruedas, double paramlargo, double paramancho)
        {
            ruedas = paramruedas;
            largo = paramlargo;
            ancho = paramancho;
            climatizador = false;
            tapiceria = "tela";
        }
        public String getInfoCoche()
        {
            return "Informacion del Coche:\n " + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }
        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        public String getExtras()
        {
            return "Extras del coche:\n" + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }
        static void Main(string[] args)
        {
            Coche coche = new Coche(4, 4.9, 1.4);
            coche.setExtras(true, "leopardo");
            Console.WriteLine(coche.getInfoCoche() + "\n" + coche.getExtras());
            Console.ReadKey();
        }
    }

    //(Colaboracion de Clases).Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositado.
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }
    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;
        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Pepe");
            cliente3 = new Cliente("Karen");
        }
        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente2.Extraer(150);
        }
        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.DepositosTotales();
            Console.ReadKey();
        }
    }
    class Dado
    {
        private int valor;
        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }

        public void Tirar()
        {
            valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es:" + valor);
        }

        public int RetornarValor()
        {
            return valor;
        }
    }
    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.RetornarValor() == dado2.RetornarValor() &&
                dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeDados j = new JuegoDeDados();
            j.Jugar();
        }
    }

    //(Propiedad). Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada
    class Client
    {
        private string nombre;
        private int monto;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Monto { set; get; }
        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene depositado la suma de " + Monto);
        }
    }
    class Bank
    {
        private Client cliente1, cliente2, cliente3;

        public Bank()
        {
            cliente1 = new Client();
            cliente1.Nombre = "Juan";
            cliente1.Monto = 0;
            cliente2 = new Client();
            cliente2.Nombre = "Ana";
            cliente2.Monto = 0;
            cliente3 = new Client();
            cliente3.Nombre = "Pedro";
            cliente3.Monto = 0;
        }

        public void Operar()
        {
            cliente1.Monto = cliente1.Monto + 100;
            cliente2.Monto = cliente2.Monto + 150;
            cliente3.Monto = cliente3.Monto + 200;
        }

        public void DepositosTotales()
        {
            int t = cliente1.Monto + cliente2.Monto + cliente3.Monto;
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            Bank banco1 = new Bank();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }

    //(Herencia). Crear un proyecto y luego crear cuatro clases llamadas: Operacion, Suma, Resta y Prueba
    namespace Herencia
    {
        class Operacion
        {
            protected int valor1;
            protected int valor2;
            protected int resultado;
            public int Valor1
            {
                set
                {
                    valor1 = value;
                }
                get
                {
                    return valor1;
                }
            }
            public int Valor2
            {
                set
                {
                    valor2 = value;
                }
                get
                {
                    return valor2;
                }
            }
            public int Resultado
            {
                set
                {
                    resultado = value;
                }
                get
                {
                    return resultado;
                }
            }
        }
        class Suma : Operacion
        {
            public void Operar()
            {
                Resultado = Valor1 + Valor2;
            }
        }
        class Resta : Operacion
        {
            public void Operar()
            {
                Resultado = Valor1 - Valor2;
            }
        }
        class Prueba
        {
            static void Main(string[] args)
            {
                Suma suma1 = new Suma();
                suma1.Valor1 = 10;
                suma1.Valor2 = 7;
                suma1.Operar();
                Console.WriteLine("La suma de " + suma1.Valor1 + " y " +
                  suma1.Valor2 + " es " + suma1.Resultado);

                Resta resta1 = new Resta();
                resta1.Valor1 = 8;
                resta1.Valor2 = 4;
                resta1.Operar();
                Console.WriteLine("La diferencia de " + resta1.Valor1 +
                  " y " + resta1.Valor2 + " es " + resta1.Resultado);

                Console.ReadKey();
            }
        }
    }

    //(Herencia). Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las propiedades para poder acceder a dichos atributos). Definir como responsabilidad un método para imprimir.Plantear una segunda clase Empleado que herede de la clase Persona.Añadir un atributo sueldo(y su propiedad) y el método para imprimir su sueldo.
    namespace Herencia2
    {
         public class Persona
        {
            protected string nombre;
            protected int edad;

            public string Nombre
            {
                set
                {
                    nombre = value;
                }
                get
                {
                    return nombre;
                }
            }

            public int Edad
            {
                set
                {
                    edad = value;
                }
                get
                {
                    return edad;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre:" + Nombre);
                Console.WriteLine("Edad:" + Edad);
            }
        }

        public class Empleado : Persona
        {
            protected float sueldo;

            public float Sueldo
            {
                set
                {
                    sueldo = value;
                }
                get
                {
                    return sueldo;
                }
            }

            new public void Imprimir()
            {
                base.Imprimir();
                Console.WriteLine("Sueldo:" + Sueldo);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                Persona persona1 = new Persona();
                persona1.Nombre = "Juan";
                persona1.Edad = 25;
                Console.WriteLine("Los datos de la persona son:");
                persona1.Imprimir();

                Empleado empleado1 = new Empleado();
                empleado1.Nombre = "Ana";
                empleado1.Edad = 42;
                empleado1.Sueldo = 2524;
                Console.WriteLine("Los dats del empleado son:");
                empleado1.Imprimir();

                Console.ReadKey();
            }
        }
        //Herencia, Constructores, Polimormismo. Escribir un ejemplo de herencia de clases.
        class Vehiculo
        {
            public string Nombre { set; get; }
            public float Largo { set; get; }
            public float Ancho { set; get; }
            public float Altura { set; get; }
            public float Peso { set; get; }
            public string Color { set; get; }
            public int CapacidadPasajerosMax { set; get; }
            public int CapacidadCombustibleMax { set; get; }
            public int VelocidadMax { set; get; }
            public int CantidadRuedas { set; get; }

            static void Main(string[] args)
            {
                Coche coche = new Coche("Chevrolet Camaro", 4);
                Avion avion = new Avion("Boeing 737 MAX", 2);

                Vehiculo[] lista = new Vehiculo[2];
                lista[0] = coche;
                lista[1] = avion;

                for (var i = 0; i < lista.Length; i++)
                {
                    lista[i].VerInformacion();
                }
            }

            public Vehiculo(string nombre)
            {
                Nombre = nombre;
            }
            public void Encender()
            {
                Console.WriteLine("Encendido");
            }
            public void Apagar()
            {
                Console.WriteLine("Apagado");
            }
            public void Desacelerar()
            {
                Console.WriteLine("Desacelerando");
            }
            public void Acelerar()
            {
                Console.WriteLine("Acelerando");
            }
            public virtual void VerInformacion()//Metodo accesible y que puede ser modificado por cualquier subclase que herede de la clase base(Vehiculo).
            {
                Console.WriteLine($"Información del Vehiculo:\n Nombre: {Nombre}");
            }
        }
        class Coche : Vehiculo
        {
            public Coche(string nombre, int cantidadRuedas) : base(nombre) //Enviar parametro nombre al constructor de la clase base 
            {
                CantidadRuedas = cantidadRuedas;
            }
            public override void VerInformacion()//Modificar el metodo heredado de la clase base
            {
                Console.WriteLine($"Información Coche: \n Nombre: {Nombre} \n Cantidad de Ruedas: { CantidadRuedas}");
            }
        }
        class Avion : Vehiculo
        {
            public int CantidadMotores { set; get; }
            public Avion(string nombre, int cantidadMotores) : base(nombre) //Enviar parametro nombre al constructor de la clase base 
            {
                CantidadMotores = cantidadMotores;
            }
            public void Aterrizar()
            {
                Console.WriteLine("Aterrizando");
            }
            public void Despegar()
            {
                Console.WriteLine("Aterrizando");
            }
            public override void VerInformacion()
            {
                Console.WriteLine($"Información Avion: \n Nombre: {Nombre} \n Cantidad de Motores: {CantidadMotores}");
            }
        }
    }
    
    //(Constructores).Orden de ejecución de los constructores con herencia. Plantear tres clases A, B, C que B herede de A y C herede de B. Definir un constructor a cada clase que muestre un mensaje.
    namespace ordenEjecucion
    {
        public class A
        {
            public A()
            {
                Console.WriteLine("Constructor de la clase A");
            }
        }

        public class B : A
        {
            public B()
            {
                Console.WriteLine("Constructor de la clase B");
            }
        }

        public class C : B
        {
            public C()
            {
                Console.WriteLine("Constructor de la clase C");
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                C obj1 = new C();
                Console.ReadKey();
            }
        }
    }
    
    //(Partial Class).Plantear una clase Rectangulo, definir dos propiedades: Lado1 y Lado2. Definir dos métodos RetornarSuperficie y RetornarPerimetro. Dividir la clase en dos archivos utilizando el concepto de "partial class".
    namespace PartialClass
    {
        //Archivo 1
        partial class Rectangulo
        {
            private int lado1;
            public int Lado1
            {
                set
                {
                    lado1 = value;
                }
                get
                {
                    return lado1;
                }
            }
            private int lado2;
            public int Lado2
            {
                set
                {
                    lado2 = value;
                }
                get
                {
                    return lado2;
                }
            }
        }
        //Archivo 2
        partial class Rectangulo
        {
            public int RetornarSuperficie()
            {
                int sup = Lado1 * Lado2;
                return sup;
            }

            public int RetornarPerimetro()
            {
                int per = Lado1 * 2 + Lado2 * 2;
                return per;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangulo rectangulo1 = new Rectangulo();
                rectangulo1.Lado1 = 5;
                rectangulo1.Lado2 = 10;
                Console.WriteLine("La superficie del rectángulo es:" +
                                    rectangulo1.RetornarSuperficie());
                Console.WriteLine("El perímetro del rectángulo es:" +
                                    rectangulo1.RetornarPerimetro());
                Console.ReadKey();
            }
        }
    }

    //(Partial Class). Plantear una clase parcial Punto. Campos de Clase(coordenadas): x e y. Métodos:  MostrarPunto, DistanciaHasta y MoverPunto. Agregar un contador de objetos Punto.
    partial class Punto
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto();
            Punto punto1 = new Punto(2, 3);
            punto1.MoverPunto(12, 22);
            punto1.MostrarPunto();

            double distancia = punto.DistanciaHasta(punto1);
            Console.WriteLine($"Distancia:{distancia}");

            Console.WriteLine($"Numero de objetos creados:{Punto.ContadorDeObjetos()}");
        }
        private void MostrarPunto()
        {
            Console.WriteLine($"X: {this.x} Y: {this.y}");
        }
        private double DistanciaHasta(Punto otropunto)
        {
            int xDif = this.x - otropunto.x;
            int yDif = this.y - otropunto.y;
            double distancia = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distancia;
        }
        private void MoverPunto(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }
    partial class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }
        private static int ContadorDeObjetos() => contadorDeObjetos;
    }

    //Ejemplos implementando interfaces y herencia de clases abstractas.
    namespace Polimorfismo
    {
        //(Interfaces). Codificar un ejemplo de clase que implemente una interfaz.
        interface IAvisos
        {
            void MostrarAviso();
        }
        class AvisoCorreo : IAvisos
        {
            static void Main(string[] args)
            {
                AvisoCorreo avisoOCA = new AvisoCorreo("OCA", "Juan García", "3/20/20", "Seguimiento del Envio", "Pedido entregado en sucursal");
                AvisoCorreo avisoGenerico = new AvisoCorreo("Temporada de Descuentos. Aprovecha un 20% a partir del segundo envio.");
                avisoGenerico.MostrarAviso();
                avisoOCA.MostrarAviso();
            }
            private string remitente;
            private string destinatario;
            private string fecha;
            private string asunto;
            private string mensaje;
            public AvisoCorreo(string mensaje)
            {
                this.remitente = "Correo Argentino";
                this.destinatario = "Todos";
                this.fecha = DateTime.Today.Date.ToShortDateString();
                this.asunto = "Novedades";
                this.mensaje = mensaje;
            }
            public AvisoCorreo(string remitente, string destinatario, string fecha, string asunto, string mensaje)
            {
                this.remitente = remitente;
                this.destinatario = destinatario;
                this.fecha = fecha;
                this.asunto = asunto;
                this.mensaje = mensaje;
            }
            public void MostrarAviso()
            {
                Console.WriteLine($"-----Aviso del Correo-----\nRemitente: {remitente} \nDestinatario: {destinatario} \nFecha: {fecha}\nAsunto: {asunto}\nMensaje: {mensaje} ");
            }
        }
        
        //(Interfaces y Tipos Enumerados). Codificar un ejemplo de clase que implemente una interfaz y tipos enumerados.
        enum Genero { Masculino, Femenino }
        interface IPersona
        {
            void ImprimirInformacionPersonal();
        }
        interface IProfesor
        {
            void ImprimirInformacionAcademica();
        }
        class Persona : IPersona
        {
            private string nombre;
            private string apellido;
            private string genero;
            private int edad;

            public Persona(string nombre, string apellido, Genero genero, int edad)
            {
                Nombre = nombre;
                Apellido = apellido;
                Genero = genero.ToString();
                Edad = edad;
            }
            public string Nombre
            {
                get { return nombre; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                        throw new ArgumentException("The name cannot be null or empty.");
                    else
                        nombre = value;
                }
            }
            public string Apellido
            {
                get { return apellido; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                        throw new ArgumentException("The lastname cannot be null or empty.");
                    else
                        apellido = value;
                }
            }
            public string Genero
            {
                get { return genero; }
                set { genero = value; }
            }
            public int Edad
            {
                get { return edad; }
                set { edad = value; }
            }
            public void ImprimirInformacionPersonal()
            {
                Console.WriteLine($"---------Información Personal---------\nNombre: {Nombre} \nApellido: {Apellido} \nGenero: {Genero} \nEdad: {Edad}");
            }
        }
        class Profesor : Persona, IProfesor
        {
            static void Main(string[] args)
            {
                Profesor profesor = new Profesor("Adrian", "López", Interfaces.Genero.Masculino, 43, "8101: Análisis Matemático II", "Fiuba");
                profesor.CalculoSueldo(6 * 5 * 4, 170);
                profesor.ImprimirInformacionPersonal();
                profesor.ImprimirInformacionAcademica();
            }
            private float sueldo;
            private string catedra;
            private string establecimiento;
            public Profesor(string nombre, string apellido, Genero genero, int edad, string catedra, string establecimiento) : base(nombre, apellido, genero, edad)
            {
                Catedra = catedra;
                Establecimiento = establecimiento;
            }
            public float Sueldo
            {
                get { return sueldo; }
            }
            public string Catedra
            {
                get { return catedra; }
                set { catedra = value; }
            }
            public string Establecimiento
            {
                get { return establecimiento; }
                set { establecimiento = value; }
            }
            public void CalculoSueldo(int horasmensuales, float salarioxhora)
            {
                this.sueldo = horasmensuales * salarioxhora;
            }
            public void ImprimirInformacionAcademica()
            {
                Console.WriteLine($"---------Información Académica----------\nSueldo: {Sueldo} \nCatedra: {Catedra} \nEstablecimiento: {Establecimiento}");
            }
        }
    }
}
