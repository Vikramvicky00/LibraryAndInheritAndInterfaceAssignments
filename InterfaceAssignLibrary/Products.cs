using System;


namespace InterfaceAssignLibrary
{
    public class Products : Customer
    {
        private int prodId;
        //static int prodId =100 ;
        //public Products()
        //{
        //    prodId += 1;
        //}
        //public int ProdId
        //{
        //    get { return prodId; }
        //}
        public int ProdId
        {
            get { return prodId; }
            set { prodId = value; }
        }
        private string prodName;
        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; }
        }

        private int qty;

        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

}
