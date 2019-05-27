using System;

namespace ConsoleApp1FirstDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 5)
            {
                Console.WriteLine("value is bigger than 5");
            }
            else
            {
                Console.WriteLine("value is not bigger than 5");
            }
            
        }
    }
}
