using System;

namespace T2008M.Labs5
{
    public delegate void Show(float a,float b);
    
    public class Delegate
    {
        public static void Main(string[] args)
        {
            Show sm1 = new Show(Summation);
            Show sm2 = new Show(new Delegate().Subtraction);
            Show sm3 = new Show(Multiplication);
            sm3 += new Delegate().devision;
            sm1(4, 2);
            sm2(4, 2);
            sm3(5, 2);
        }
        public static void Summation(float a, float b)
        {
            float s = a + b;
            Console.WriteLine("Tong: " + s);
        }

        public void Subtraction(float a, float b)
        {
            float s = a - b;
            Console.WriteLine("Hieu: " + s);
        }

        public static void Multiplication(float a, float b)
        {
            float s = a * b;
            Console.WriteLine("Tich: " + s);
        }

        public void devision(float a, float b)
        {
            float s = a / b;
            Console.WriteLine("Thuong: " + s);
        }
    }
}