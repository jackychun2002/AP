using System.Collections.Generic;
using T2008M.Session3;

namespace T2008M.Labs3
{
    public class Cart
    {
        public int id;
        public string customerName;
        public double grandTotal;
        public List<Product> productsList;
        public string city;
        public string country;

        public Cart()
        {
            productsList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            productsList.Add(product);
            grandTotal += product.Price;
        }

        public void RemoveProduct(Product product)
        {
            if (productsList.Remove(product))
            {
                grandTotal -= product.Price;
            }
        }

        public double CalcGrandTotal()
        {
            if (city.Equals("Ha noi") || city.Equals("HCm")) return grandTotal * 101 / 100;
            if (country.Equals("viet Nam")) return grandTotal * 102 / 100;
            return grandTotal * 105 / 100;
        }
    }
}