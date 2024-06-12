using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Напишите оператор отношений");
            char operation = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Напиши 2-ое число");
            float b = float.Parse(Console.ReadLine());
            if (operation == '+')
            {
                Console.WriteLine("Сумма");
                Console.WriteLine(a + b);
            }

            else
            {
                Console.WriteLine("разница");
                Console.WriteLine(a - b);
            }
        }
    }
}
