using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_пр_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            char znak;
            Console.WriteLine("Введите первую переменную: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак:");
            znak = Convert.ToChar(Console.ReadLine());
            if (znak == '+')
            {
                c = a + b;
                Console.WriteLine("Ответ: " + c);
            }
        }
    }
}
