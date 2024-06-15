using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopC_sharp
{
    internal class ExemploDoWhileLoop
    {
        public static void Main(string[] args)
        {
            int A = 0;
            do
            {
                Console.WriteLine(A);
                A++;
            }
            while (A < 5);
        }
    }
}
