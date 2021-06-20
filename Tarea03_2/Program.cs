using System;

namespace Tarea03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 15;
            double A = 3.67;
            char B = 'G';

            Console.WriteLine("Variable N = {0} ", N);
            Console.WriteLine("Variable A = {0}", A);
            Console.WriteLine("Variable B = {0}", B);

            Console.WriteLine("{0} + {1} = {2}", N, A, N + A);
            Console.WriteLine("{0} - {1} = {2}", A, N, A - N);
            Console.WriteLine("Valor numérico del carácter {0} = {1}", B,(int)B);

            Console.ReadKey();
        }
    }
}
