using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework4_2
{
    public delegate void Tick(object sender);
    public delegate void BellTime(object sender, clockTime args);
    public class clockTime
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int seconds { get; set; }
    }
    public class Clock
    {
        public event Tick onTick;
        public event BellTime setBell;
        public void Start()
        {
            onTick(this);
        }

    }
    public class Form
    {
        private int Hour = 0;
        private int Minute = 0;
        private int Second = 0;
        public void setBell(int a,int b,int c)
        {
            Hour = a;
            Minute = b;
            Second = c;
        }
        public Clock clock = new Clock();
        public Form()
        {
            clock.onTick += Clo_Bell;
            clock.onTick += Clo_tick;
        }
        void Clo_Bell(object sender)
        {
            Console.WriteLine($"设定时间为{Hour}时{Minute}分{Second}秒");
        }
        void Clo_tick(object sender)
        {
            while (!(System.DateTime.Now.Hour == Hour && System.DateTime.Now.Minute == Minute && System.DateTime.Now.Second == Second))                
            {
                Console.WriteLine($"{System.DateTime.Now.Hour}时{System.DateTime.Now.Minute}分{System.DateTime.Now.Second}秒");
                System.Threading.Thread.Sleep(1000); 
            }
            if(System.DateTime.Now.Hour == Hour && System.DateTime.Now.Minute == Minute && System.DateTime.Now.Second == Second){
                Console.WriteLine("设定的时间到了");
            }

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.setBell(23,27,30);
            form1.clock.Start();
        }
    }
}
