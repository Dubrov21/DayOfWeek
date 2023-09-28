using System;

namespace DayOfWeek
{
    public class Program
    {
        static void PrintWeekend(int number)
        {
            if(number !=6 && number !=7)
            {
                Console.WriteLine("Это будний день");
            }
            else
            {
                Console.WriteLine("Это выходной");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Введите номер дня недели");
            int number;

            if (args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            PrintWeekend(number);
        }
    }
}
