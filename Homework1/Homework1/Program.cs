using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input second integer");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input symbol");
            char  s = Convert.ToChar (Console.ReadLine());
            switch (s)
            {
                case '+':
                    Console.WriteLine($"结果为：{a + b}");
                    break;
                case '-':
                    Console.WriteLine($"结果为：{a - b}");
                    break;
                case '*':
                    Console.WriteLine($"结果为：{a * b}");
                    break;
                case '/':
                    Console.WriteLine($"结果为：{a / b}");
                    break;
                default:
                    Console.WriteLine("符号错误");
                    break;
            }

        }
    }
}
