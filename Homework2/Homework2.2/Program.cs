using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =new int[] { 1,2,23,41,4,73,24,81,76} ;
            Console.WriteLine("数组如下");
            foreach (int a in array) { Console.Write( $"{a} "); };
            Console.WriteLine("\n数组的合为");
            int   Sum=0;
            foreach (int a in array) { Sum += a; };
            Console.WriteLine(Sum );
            Console.WriteLine("数组的平均数为");
            Console.WriteLine(Sum /array .Length  );
            int Max = array[0];int  Min = array [0];
            foreach (int a in array)
            {
                if (a >Max) { Max = a; }
                if (a < Min) { Min = a; }
            }
            Console.WriteLine($"最大值为{Max} 最小值为{Min }");



        }
    }
}
