using System;

namespace ReversePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = rows; i >=1; i--)
            {
                for (j = rows; j >= i; j--)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }

        }
    }
}
