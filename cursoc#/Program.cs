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
            int year = Convert.ToInt16("52");
            double doble = 2.2;

            string nombre = "Joel";

            String nombres = "Alex Joel";

            decimal decimals = 2.07M;
            float flotante = 8.3F;
            Console.WriteLine(nombres + "Hello world! {0} {1} {2} {3}", year, doble, nombre, decimals);

            Console.ReadLine(); 
        }
    }
}
