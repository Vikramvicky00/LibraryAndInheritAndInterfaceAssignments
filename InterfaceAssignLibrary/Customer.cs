using System;


namespace InterfaceAssignLibrary
{
    public class Customer
    {
        static int custId = 10000;
        public Customer()
        {
            custId += 1;
        }
        public int CustomerId
        { 
            get 
            {
                return custId; 
            }
        }

        private string CustName;
        public string CustomerName
        {
            get { return CustName; }
            set { CustName = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

    }
}
