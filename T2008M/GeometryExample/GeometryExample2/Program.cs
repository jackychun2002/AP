namespace T2008M.GeometryExample2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tiger = new Tiger(100, "Tiger");
            var lion = new Lion(200, "Liom");
            
            tiger.Show();
            lion.Show();
        }
    }
}