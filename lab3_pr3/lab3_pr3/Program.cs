using System;

namespace lab3_pr3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть кількість елементі масиву: \t");

            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            try
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"Введіть елемент масиву під індексом {i}:\t ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Вивід масиву: ");
                for(int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вихід за межі діапазону");
            }
            catch (FormatException)
            {
                Console.WriteLine("Невірний формат вводу даних");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостатньо пам'яті для створення нового об'єкта");
            }
        }
    }
}