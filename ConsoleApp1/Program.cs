using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                Console.WriteLine(("\nРезультат добавления = ") + (a + b) + "\nРезультат отнимания =  " + (a - b)
                    + "\nРезультат умножения = " + (a * b) + "\nРезультат деления = " + (a / b));
                Console.WriteLine("Хотите продолжить? (да/нет)");
                string conti = Console.ReadLine();
                if (conti.ToLower() != "да")
                    break;
                
            }  
        }
    }
}