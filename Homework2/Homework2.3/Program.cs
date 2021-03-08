using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数求这个数以内的素数");
            int num = Int32.Parse(Console.ReadLine());
             bool judge(int a) 
            {   if (a == 2 || a == 3 || a == 5 || a == 7) { return true; };
                if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0) { return false; }
                else return true;
            }
            for (int i=2; i < num  ; i++)
            {
                if (judge (i)) { Console.WriteLine(i); };
            }
        }
    }
}
