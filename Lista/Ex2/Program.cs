using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            n1 = n1 + n2;
            Console.WriteLine("Total: {0} ", n1);
        }
    }
}
