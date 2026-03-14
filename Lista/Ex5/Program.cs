using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n,d;
            Console.Write("Digite um numero: ");
            n = double.Parse(Console.ReadLine());
            d = n * 2;
            Console.WriteLine("O dobro de {0} é: {1} ", n, d);
        }
    }
}
