using System;

namespace T2008M.Session2
{
    public abstract class Animal
    {
        public string kind;

        public void Eat()
        {
            Console.WriteLine("Eat Something....");
        }

        public virtual void DoSomeThing()
        {
            Console.WriteLine("Do something");
        }

        public abstract void Running();
    }
}