using System;

namespace lab3_1
{
    class Constant
    {
        public const int N = 4;
        public const int M = 5;
        public const int L = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] A = new int[Constant.N] { 1, 2, 3, 4 };
            int[] B = new int[Constant.M] { 5, 6, 7, 9, 10 };
            int[] C = new int[Constant.L];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)                       
                Console.Write (A[i] + " "); //видалити парні елементи
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] % 2 != 0)
                    Console.Write(B[i] + " "); //видалити непарні елементи
            }
            
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] + B[i];               
                Console.Write(C[i] + " "); //сформувати новий масив на сонові двох попередніх
            }          
        }
    }
}