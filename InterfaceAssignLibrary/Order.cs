using System;


namespace InterfaceAssignLibrary
{
    public class Order : Products, IOperations
    {
        static int orderId = 1000;
        public enum paymode
        {
            Cash,
            UPI,
            Card
        }
     
        public Order()
        {
            orderId += 1;
        }
       
        public int OrderID
        {
            get { return orderId; }
        }

        private DateTime orderdate = DateTime.Now;

        public DateTime Orderdate
        {
            get { return orderdate; }
        }

        private paymode _paymode;

        public paymode GetPaymentMode
        {
            get { return _paymode; }
            set { _paymode = value; }
        }



        public void AddToCart(int prodid, string pname, int qty, int price)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("|---Items Added----|");
            Console.WriteLine("--------------------");
            Console.WriteLine("Product Id: {0}",prodid);
            Console.WriteLine("Product Name: {0}", pname);
            Console.WriteLine("Price : {0}", price);
            Console.WriteLine("Quantity : {0}", qty);
            Console.WriteLine("Total : {0}", price*qty);
            Console.WriteLine("--------------------");
        }



        public void PaymentGateway(int amt)
        {
            Console.WriteLine("Choose Payment Mode:");
            Console.WriteLine(" 1.Cash \n 2.Upi \n 3.Card");
            GetPaymentMode = (paymode)(Convert.ToInt32(Console.ReadLine()) - 1);
            Console.WriteLine("The Total Amount Rs. {0} Should be pay by {1}", amt, GetPaymentMode);
        }
     
        public int calculate(int p,int q) {
            return p * q;
        }
        public void BuyNow()
        {
            Console.WriteLine();
            Console.WriteLine("Booking the order...");
            Console.WriteLine();
        }

        public void BookOrder(int cid,string cname,int amt)
        {
            Console.WriteLine();
            PaymentGateway(amt);
            BuyNow();
            Console.WriteLine("============================");
            Console.WriteLine("..Order Booked SucessFully..");
            Console.WriteLine("============================");
            Console.WriteLine(" Order booked for \n Customer Name: {1} \n Generated Customer ID : {0} \n Total Amount to be Recevied Rs: {4} by {5} \n Generated Order Id : {2} \n Booked on {3}  ", cid,cname , OrderID,Orderdate,amt,GetPaymentMode);
        }
    }
}
