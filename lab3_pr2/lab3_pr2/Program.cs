using System;

namespace lab3_pr2
{
    class Constant
    {
        public const int N = 10;
    }

    class Program
    {
        static void Main()
        {
            int[] myArray = new int[Constant.N];
            int i;
            for (i = 0; i < Constant.N; i++)
                myArray[i] = i * i;
            for (i = 0; i < Constant.N; i++)
                Console.WriteLine(myArray[i]);
        }
    }
}