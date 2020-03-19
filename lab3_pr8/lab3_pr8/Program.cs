using System;

namespace ConsoleApplication
{
    class Class
    {
        static int[] Input()
        {
            Console.Write("Введіть розмірність масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] myArray = Input();
            int max = Max(myArray);
            int kol = 0;
            for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] == max) ++kol;
            Console.WriteLine("Кількість максимальних елементів = " + kol);
            
            for (int i = 1; i < myArray.Length; ++i)
                if (myArray[i] > max) max = myArray[i];
            Console.WriteLine("Максимальний елемент = " + max);

            int min = myArray[0];  // 
            for (int i = 1; i < myArray.Length; ++i)
                if (myArray[i] < min) min = myArray[i];
            Console.WriteLine("Мінімальний елемент = " + min);

            int j, sum = 0;
            for (j = min + 1; j < max; j++)
            {
                sum += j;
            }
            Console.WriteLine("Сума чисел між max(перший) i min(останній) = " + sum);
        }
    }
}