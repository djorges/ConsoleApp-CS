using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arreglos
    {
        static void Main(string[] args) {

        }
    }

    //(Arreglos). Escribir un metodo que reciba un arreglo. Sumarle 10 e imprimir el valor almacenado en cada posicion del mismo.
    class ReferenciaArr
    {
        static void Main(string[] args)
        {
            //Declaracion e Inicializacion del arreglo
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 17;
            numeros[2] = 12;
            numeros[3] = 67;
            //Procesar
            ProcesarDatos(numeros);//Nota:Paso de variables por referencia. La variable que se recibe como parámetro en la función apunta exactamente a la misma dirección de memoria que la variable original
                                   //Recorrer e Imprimir arreglo
            foreach (int numero in numeros)
            {
                Console.WriteLine($"numero: {numero}");
            }
        }
        static void ProcesarDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;//sumar 10
            }
        }
    }

    //(Arreglos). Se desea guardar los sueldos de 5 operarios.
    class SueldoOperarios
    {
        private float[] sueldos;
        static void Main(string[] args)
        {
            SueldoOperarios obj = new SueldoOperarios();
            obj.CargarDatos();
            obj.Imprimir();
        }
        public void CargarDatos()
        {
            sueldos = new float[5];
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese sueldo" + i);
                String linea;
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
        }
    }

    //(Matriz):Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.
    class ImprimirCargarMatriz
    {
        private int[,] mat;
        public void Inicializar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("Ultima fila");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[mat.GetLength(0) - 1, c] + " ");
            }
        }

        static void Main(string[] args)
        {
            ImprimirCargarMatriz ma = new ImprimirCargarMatriz();
            ma.Inicializar();
            ma.Imprimir();
            ma.ImprimirUltimaFila();
            Console.ReadKey();
        }
    }
}
