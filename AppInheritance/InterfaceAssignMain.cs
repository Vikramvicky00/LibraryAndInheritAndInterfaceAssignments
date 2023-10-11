using System;
using InterfaceAssignLibrary;

namespace AppInheritInterface
{
    internal class InterfaceAssignMain
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            Console.WriteLine("Enter Customer Name:");
            c1.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter City:");
            c1.City = Console.ReadLine();

            Products p1 = new Products();
            p1.ProdId = 1201;
            Console.WriteLine("Enter Product Name:");
            p1.ProdName = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            p1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            p1.Quantity = Convert.ToInt32(Console.ReadLine());

            //Products p2 = new Products();
            //p1.ProdId = 1202;
            //Console.WriteLine("Enter Product Name:");
            //p2.ProdName = Console.ReadLine();
            //Console.WriteLine("Enter Price:");
            //p2.Price = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Quantity:");
            //p2.Quantity = Convert.ToInt32(Console.ReadLine());

            //Products p3 = new Products();
            //p3.ProdId = 1203;
            //Console.WriteLine("Enter Product Name:");
            //p3.ProdName = Console.ReadLine();
            //Console.WriteLine("Enter Price:");
            //p3.Price = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Quantity:");
            //p3.Quantity = Convert.ToInt32(Console.ReadLine());

            //Products[] product=new Products[3];
            //product[0] = p1;
            //product[1] = p2;
            //product[2] = p3;

            Order o1 = new Order();
            o1.AddToCart(p1.ProdId, p1.ProdName, p1.Quantity, p1.Price);
            //o2.AddToCart(p2.ProdId, p2.ProdName, p2.Quantity, p2.Price);
            //o3.AddToCart(p3.ProdId, p3.ProdName, p3.Quantity, p3.Price);
            //int t=0;//total of diferents products
            //foreach(var i in product)
            //{
            //    int amt = o1.calculate(i.Price, i.Quantity);
            //    t += amt;
            //}
            int t =o1.calculate(p1.Price,p1.Quantity);
            o1.BookOrder((c1.CustomerId-2),c1.CustomerName,t);
        }
    }
}
