using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数字");
            int num = Int32.Parse(Console.ReadLine());
            int i = 2;
            while (num > 1)
            {
                if (num % i == 0) 
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
                else
                {
                    i = i + 1;
                }
            }
        }
    }
}
