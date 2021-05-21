using System.Collections.Generic;

namespace T2008M.Session3
{
    public class Product
    {
        private string productName;
        private decimal price;
        public List<string> gallery = new List<string>();
        //ban than List cung da co indexers
        // indexer
        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value;  }
        }
            
        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public decimal Price
        {
            get
            {
                return price + 10;
            }
            set
            {
                price = value - 10;
            }
        }
    }
}