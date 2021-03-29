using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service  = new OrderService();
            Order p1 = new Order(1, "小李", "2021.1.1", "武汉大学");
            Order p2 = new Order(2, "小马", "2021.2.2", "浙江大学");
            Order p3 = new Order(3, "小谷", "2021.3.3", "东南大学");
            Order p4 = new Order(4, "小李", "2021.1.1", "武汉大学");
            OrderDetails g1 = new OrderDetails("笔",5.0,1);
            OrderDetails g2 = new OrderDetails("本子", 10.0, 1);
            OrderDetails g3 = new OrderDetails("笔盒", 20.0, 1);
            OrderDetails g4 = new OrderDetails("书包", 100.0, 1);
            p1.AddItems(g1);
            p1.AddItems(g2);
            p2.AddItems(g2);
            p2.AddItems(g3);
            p3.AddItems(g3);
            p3.AddItems(g4);
            service.AddItems(p3);
            service.AddItems(p2);
            service.AddItems(p1);
            Console.WriteLine("------------------原本的订单详情为---------------------------");
            Console.WriteLine( service.ToString());
            Console.WriteLine("------------------现在添加一条订单---------------------------");
            service.AddItems(p4);
            Console.WriteLine(service.ToString());
            Console.WriteLine("------------------现在为订单添加订单明细---------------------------");
            p4.AddItems(g2);
            p4.AddItems(g4);
            Console.WriteLine(service.ToString());
            Console.WriteLine("------------------现在为订单以订单号升序排序---------------------------");
            service.order.Sort();
            Console.WriteLine(service.ToString());
            Console.WriteLine("------------------现在查询订单号为2的订单---------------------------");
            service.SelectID(2);
            Console.WriteLine("------------------现在查询总金额为110的订单---------------------------");
            service.SelectSum(110);
            Console.WriteLine("------------------现在查询商品名称为书包的订单---------------------------");
            service.SelectName("书包");
            Console.WriteLine("------------------现在查询客户为小李的订单---------------------------");
            service.SelectName("小李");
            Console.WriteLine("------------------现在删除订单号为4的的订单---------------------------");
            service.Remove(4);
            Console.WriteLine("\n"+service.ToString());
            Console.WriteLine("------------------现在修改订单号为1的订单的地址和商品数目---------------------------");
            p1.OrderAddress = "武汉大学信息学部";
            p1.orderDe[0].Num = 2; p1.orderDe[1].Num = 2;
            Console.WriteLine(service.ToString());
        }
    }
}
