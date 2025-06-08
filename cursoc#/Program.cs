using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Decimales*/

            /*
            int year = Convert.ToInt16("52");
            double doble = 2.2;

            string nombre = "Joel";

            String nombres = "Alex Joel";

            decimal decimals = 2.07M;
            float flotante = 8.3F;

            bool valor = true;

            char letra = 'A';

            Decimal de = 28.6M;
            Boolean valor2 = false;
            
            Console.WriteLine(nombres + "Hello world! {0} {1} {2} {3}", year, doble, nombre, decimals);

            Console.ReadLine(); 
            */

            /*
            int valor1 = 3;
            int valor2 = 4;
            int valor3 = 5;
            int valor4 = 2;
            decimal valor5 = 3M;
            decimal valor6 = 7M;

            decimal valor7 = 3M;
            decimal valor8 = 4M;


            //var suma = valor1 + valor2
            valor1 += valor2;
            valor2 += valor1;

            valor3 -= valor4;
            valor4 -= valor3;

            valor5 /= valor6;
            valor6 /= valor5;

            valor7 %= valor8;
            valor8 %= valor7;
            Console.WriteLine("Resultado {0} {1} {2} {3} {4} {5} {6} {7}", valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8);
            Console.ReadLine();
            */

            /*
            int valor1 = 0;
            int valor2 = 2;

            var data = valor1 == valor2;
            Console.WriteLine("Resultado {0}", data);

            Console.ReadLine();
            */

            /*
            int valor1 = 9;
            int valor2 = 8;

            double valor3 = 10;
            double valor4 = 11;
            string name;

            var data = valor1 != valor2;
            
            if (data)
            {
                name = "Alex";
            }
            else
            {
                name = "Joel";
            }
            
            name = data ? "Alex" : "Joel";
            Console.WriteLine("Resultado {0}", name);

            Console.ReadLine();
            */

            /*
            string[] cadenas = new string[5];
            cadenas[0] = "Joel";
            cadenas[1] = "John";
            cadenas[2] = "Seidy";
            cadenas[3] = "Cindy";
            cadenas[4] = "Alex";
            string[] name = { "Joel", "John", "Seidy", "Cindy", "Alex" };
            int[] age = new int[5];
            age[0] = 5;
            age[1] = 34;
            age[2] = 23;
            age[3] = 53;
            age[4] = 54;
            int[] ages = { 8, 45, 23, 54 };

            Console.WriteLine("Resultado {0} {1} {2} {3} {4} {5}", cadenas.Length, cadenas[2], cadenas[3], name[1], age[2], ages[3]);

            Console.ReadLine();
            */

            /*
            double[,] doble2 = new double[2, 2] { { 6, 3.6 }, { 6.3, 5.6 } };

            double[,,] doble3 = new double[2, 2, 3] { { { 3.2, 6.9, 8.9 }, { 6.8, 5.7, 5.9 } }, { { 5.2, 4.3, 1.8 }, { 5.6, 8.4, 8.7 } } };

            Console.WriteLine("Resultado {0} {1}", doble2[1, 0], doble3[0, 0, 2 ]);
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Resultado: {0}", i);
            }


            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Resultado: {0}", i);
            }
            Console.ReadLine();
            */

            /*
            string[] name = { "Alex", "Joel", "Pdhn" };
            int[] age = { 52, 45, 65 };
            
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Resultado {0} ", name[i] + " age " + age[i]);
            }
            
            Console.ReadLine();

            foreach (var item in name)
            {
                Console.WriteLine("Resultado {0}", item);
            }

            Console.ReadLine();
            */

            int pisos = 0;
            int[] arreglo = new int[1];

            Console.WriteLine("Ingrese el numero de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= pisos; i++)
            {
                int[] pascal = new int[i];

                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    if(k == 0 || k == (i -1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");   
                }
                arreglo = pascal;
                Console.WriteLine(" ");

            }
            Console.ReadLine();

        }
    }
}
