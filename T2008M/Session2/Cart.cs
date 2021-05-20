using System;

namespace T2008M.Session2
{
    public class Cart:Animal,ICart,IAnimal
    {
        public string name;

        public override void Running()
        {
            Console.WriteLine("Cart Running");
        }

        public void Speak()
        {
            Console.WriteLine("Meo Meo");
        }

        public void Live()
        {
            Console.WriteLine("live");
        }

        public void MeoMeo()
        {
            base.DoSomeThing();
            base.Eat();
        }

        public void MeoMeo(string msg)
        {
            base.DoSomeThing();
            base.Eat();
            Console.WriteLine(msg);
        }

        public void MeoMeo(string msg,int n)
        {
            
        }

        public override void DoSomeThing()
        {
            Console.WriteLine("MeoMeo Do Some thing...");
        }

        public new void Eat()
        {
            Console.WriteLine("MeoMeo eat");
        }
    }
}