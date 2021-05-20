using System;

namespace T2008M
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello word!");
            Console.WriteLine("Nhap 1 chuoi:");
            string s = Console.ReadLine();
            Console.WriteLine("s = "+s);
            Console.WriteLine("Nhap vao 1 so nguyen:");
            int n ;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                n = 0;
            }
            Console.WriteLine("So vua nhap: "+n);
            if (CheckPrime(n))
            {
                Console.WriteLine(n+" la so nguyen to");
            }
            else
            {
                Console.WriteLine(n+" khong phai nguyen to");
            }
        }

        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}