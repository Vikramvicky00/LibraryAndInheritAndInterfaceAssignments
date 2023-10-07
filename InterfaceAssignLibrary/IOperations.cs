using System;


namespace InterfaceAssignLibrary
{
    internal interface IOperations
    {
        void AddToCart(int prodid, string pname, int qty, int price);
        void PaymentGateway(int amt);
        void BuyNow();
    }
}
