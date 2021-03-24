using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public  void Print(int a )
        {
            Console.WriteLine(a);
        }
        public void ForEach(GenericList<T> a,Action<T> action)
        {
            Node<T> node = a.Head;
            while (node !=null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> array= new GenericList<int>();
            Action<int> action1 = array.Print;
            Random random = new Random();
            int sum = 0;
            int Maxvalue = 0;
            int Minvalue = int.MaxValue;
            Action<int> action2 = delegate (int a)
            {
                if (a > Maxvalue)
                {
                    Maxvalue = a;
                }
                if (a < Minvalue)
                {
                    Minvalue = a;
                }
            };
            for (int i = 0; i < 10; i++)
            {
                array.Add((random.Next(20)));
            }
            array.ForEach(array, s => sum += s);
            array.ForEach(array, action1);
            array.ForEach(array, action2);
            Console.WriteLine($"和为{sum }");
            Console.WriteLine($"最大值为{Maxvalue},最小值为{Minvalue}");

        }
    }
}
