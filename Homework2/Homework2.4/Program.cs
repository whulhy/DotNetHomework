using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入矩阵的行数");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("输入矩阵的列数");
            int n = int.Parse(Console.ReadLine());
            int[,] Array=new int [m,n];
            Console.WriteLine("输入矩阵,以逗号隔开");
            for (int i = 0; i < m; i++)
            {
                string s = Console.ReadLine();
                string[] sArray = s.Split(',');
                  for (int j=0;j < n; j ++)
                  {
                      Array[i,j] = int.Parse(sArray[j]);
                  }
            }
           Boolean Judge(int[,] martix)
            {
                bool a=true ;
                for (int i = 0; i<m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i<m-1&&j<n-1&&martix [i,j]!=martix[i + 1, j + 1])
                        {
                            a= false ;
                        }
                    }
                }
                return a;
            }
            if (Judge(Array)) { Console.WriteLine(@"此矩阵是托普利茨矩阵 "); }
            else { Console.WriteLine(@"矩阵不是托普利茨矩阵 "); };
        }
    }
}

