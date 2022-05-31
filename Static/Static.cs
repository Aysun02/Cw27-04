using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Konul = new Person();
           
            Person Aysun = new Person();

            Person Ebulfet = new Person();

            Person Fezail = new Person();

            Konul.count();
            Console.WriteLine("Age for Konul: {0}", Konul.GetAge());

            Aysun.count();
            Console.WriteLine("Age for Aysun: {0}", Aysun.GetAge());

            Ebulfet.count();
            Console.WriteLine("Age for Ebulfet: {0} ", Ebulfet.GetAge());

            Fezail.count();
            Console.WriteLine("Age for Fezail: {0}", Fezail.GetAge());



        }
    }
}
