using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace T2008M.Labs1
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string description;
        public List<string> gallery = new List<string>();

        public Product()
        {
            gallery = new List<string>();
        }

        public Product(int id, string name, decimal price, int qty, string image)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            gallery = new List<string>();
        }

        public void GetInfo()
        {
            Console.WriteLine("Ten Sp:"+ name);
            Console.WriteLine("Gia:"+price);
            Console.WriteLine("sSL:"+qty);
        }

        public void CheckQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("In Stock");
                return;
            }
            Console.WriteLine("Out of Stock");
        }

        public bool AddImage(string image)
        {
            if (gallery.Count >= 10)
                return false;
            gallery.Add(image);
            return true;
        }

        public bool RemoveImage(string im)
        {
            gallery.Remove(image);
            return true;
        }
    }
}