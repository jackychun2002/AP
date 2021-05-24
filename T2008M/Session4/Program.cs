using System;

namespace T2008M.Session4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                x++;
                int z = x / y;
                Console.WriteLine("z = " + z);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Loi toan hoc");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally..");
            }
        }
        }
    }
}