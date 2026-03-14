using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C,F;
            Console.Write("Digite a temperatura: Cº ");
            C = double.Parse(Console.ReadLine());
            F = C * 9/5 + 32;
            Console.WriteLine("Temperatura em Fahrenheit: {0} ", F);
        }
    }
}
