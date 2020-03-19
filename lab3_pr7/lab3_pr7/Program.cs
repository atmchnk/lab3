using System;

public static class Class
{
    static int n; //змінна для рядків     
    static int m; //змінна для стовпчиків      
    static int[,] a; //початковий масив    
    static int[,] b; //новий масив 
    static int k; //змінна для видалення стовпчика

    public static void Input()                                         
    {
        Console.WriteLine("Введіть квадратну матрицю  ");
        Console.Write("Введіть кількість стовпчиків: ");                             
        m = Convert.ToInt32(Console.ReadLine());      
        
        Console.Write("Введіть кількість рядків: ");                                
        n = Convert.ToInt32(Console.ReadLine());  
        
        Console.WriteLine("Стовпчиків: {0}, рядків: {1}", m, n);
        a = new int[n, m];                                        
                                                                           
        Random rnd = new Random(); //заповнюємо масив елементами                                         
                                                                            
        for (int i = 0; i < n; i++)                                     
        {                                                                   
            for (int j = 0; j < m; j++)                                 
            {                                                               
                a[i, j] = rnd.Next(1, 10);                                 
            }                                                               
        }                                                                   
    }                                                                       
    
    public static void Print() //виводить масив на екран                   
    {                                                   
        Console.WriteLine("Вихідний масив: "); 
        for (int i = 0; i < m; i++)                 
        {                                               
            for (int k = 0; k < n; k++)             
            {                                           
                Console.Write(a[i, k] + " ");                
            }                                           
            Console.WriteLine();                        
        }                                               
    }                                                   
                                                        
    public static void DeleteArray()                    
    {                                                       
        Console.Write("Введіть номер стовпця для видалення: ");         
        k = Convert.ToInt32(Console.ReadLine());    
        k--;                                        
        b = new int[n, m - 1]; //розмірність масиву менше на 1 стовпець, ніж у вихідному
        Console.WriteLine("Змінений масив: ");

        for (int i = 0; i < n; i++)                     
        {                                                   
            for (int j = 0; j < m - 1; j++) //заповнюємо новий масив виключаючи номер стовпця,           
            {                               //який необхідно видалити              
                if (k > j)                          
                {                                           
                    b[i, j] = a[i, j];              
                }                                           
                else                                        
                {                                           
                    b[i, j] = a[i, j + 1];            
                }               
                Console.Write(b[i, j] + " ");               
            }                                               
            Console.WriteLine();                            
            Console.ReadKey();                              
        }                                                   
    }                                                       
}

class Program
{ 
    static void Main()          
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;       
        Class.Input();    
        Class.Print();   
        Class.DeleteArray();   
    }                           
}