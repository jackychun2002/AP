using System;

namespace T2008M.GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            Console.Write("Nhập Kích thước hình trụ : ");
            while (true)
            {
                try
                {
                    Console.Write("Bán Kính");
                    cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Chiều Cao: ");
                    cylinder.Height = Convert.ToDouble(Console.ReadLine());

                    cylinder.Process();
                    Console.Write(cylinder.Result());
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }
    }
}