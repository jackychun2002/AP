using System;

namespace T2008M.Session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p = new Product();
            p.ProductName = "Tui GuCi";
            p.Price = 1000; // khong phai attibute la Property
            p.gallery.Add("image1.png");//dang su dung indexers
            p.gallery.Add("images2.png"); // dang su dung indexers
            p[1] = "image2.png"; // set
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(p[i]); // get
            }
        }
    }
}

namespace T2008M.Session3
{
    public class Cart
    {
        
    }
}