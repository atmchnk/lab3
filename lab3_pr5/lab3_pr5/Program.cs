using System;

namespace Arrays
{
    class Program
    {
        static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static void Change(int[,] mas) //ф-ія обчислення парних елементів масиву
        {
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] % 2 == 0)
                    {
                        sum += mas[i, j];
                    }
                }
            }
            Console.WriteLine("Сума парних елементів: {0}", sum);
        }

      static void InputArray(int[,] mas) //ф-ія заповнення масиву елементами з клавіатури
        {          
            for (int n = 0; n < 3; n++)
            {
                for (int m = 0; m < 3; m++)
                {
                    Console.WriteLine("Введіть елементи масиву від 1 до 9: ");
                    mas[n, m] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
     
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {
                int[,] mas = new int[3, 3];
                InputArray(mas);
                PrintArray("Вихідний масив: ", mas);
                Change(mas);
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Невірний формат вводу даних.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переповнення");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостатньо пам'яті для створення нового об'єкта");
            }
        }
    }
}