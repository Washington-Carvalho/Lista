using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, d;
            Console.Write("Digite um valor em USD$: ");
            d = double.Parse(Console.ReadLine());
            r = d * 5.33;
            Console.WriteLine("Valor de USD$ {0} em R$: {1} ", d, r);
        }
    }
}
