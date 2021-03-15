using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework3_1;

namespace Homework3_2
{
    public class Factory
    {
        public static Area createArea(int condition)
        {
            Area area = null;
            switch (condition)
            {
                case 0:
                    area = new Rectangle(2, 5);
                    break;
                case 1:
                    area = new Delta(6, 6, 6);
                    break;
                case 2:
                    area = new Square(4);
                    break;
                default:break;
            }
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(0, 3);
                Area area = Factory.createArea(a);
                sum += area.getArea();
                Console.WriteLine($"第{i}个对象的面积为{area.getArea()}");
            }
            Console .WriteLine ($"和为{sum}" );
        }
    }
}
