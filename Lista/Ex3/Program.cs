using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m;
            Console.Write("Digite sua primeria nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n3 = double.Parse(Console.ReadLine());
            m = (n1 + n2 + n3) / 3;
            Console.WriteLine("Média: {0} ", m);
            if (m >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
