using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    public interface Area
    {
        double getArea();//定义成属性更好
        void  Isrightful();
    }
    public class Rectangle: Area 
    {
        private  double length;
        private  double width;
        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public double getArea()
        {
            return length * width;
        }
        public void Isrightful()
        {
            if (this.length > 0 && this.width > 0)
            {
                Console.WriteLine("形状合法");
            }
            else { Console.WriteLine("形状不合法"); }
        } 
        public double  Length { get=>length ; set=>length =value ; }
        public double  Width { get => width ; set => width  = value; }

    }
    public class Delta :Area 
    {
        private double len1;
        private double len2;
        private double len3;
        public double Len1 { get => len1; set => len1 = value; }
        public double Len2 { get => len2; set => len2 = value; }
        public double Len3 { get => len3; set => len3 = value; }
       public  Delta (double a,double b,double c)
        {
            this.len1 = a;
            this.len2 = b;
            this.len3 = c;
        }
        public double getArea()
        { double  p = (len1 + len2 + len3)/2;
            return Math.Sqrt(p * (p - len1) * (p - len2) * (p - len3));
        }
        public void Isrightful()
        {
            if ((len1 + len2) > len3 && (len1 + len3) > len2 && (len2 + len3) > len1)
            {
                Console.WriteLine("形状合法");
            }
            else Console.WriteLine("形状不合法");
        }
    }
    public class Square : Rectangle
    {
        public Square(double length) : base(length, length) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3, 6);
            Delta del = new Delta(4, 5, 6);
            Square squ = new Square(7);
            rec.Isrightful();
            Console.WriteLine($"长方形面积为{rec.getArea()}" );
            rec.Length = 5;
            Console.WriteLine($"改长度为5后，长方形面积为{rec.getArea()}");
            del.Isrightful();
            Console.WriteLine($"三角形面积为{del.getArea()}");
            squ.Isrightful();
            Console.WriteLine($"正方形面积为{squ .getArea()}");
        }
    }
}
