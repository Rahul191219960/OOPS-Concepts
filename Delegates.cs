using System;
namespace OOPS
{
    public class delegates
    {
        public int sum(int x, int y)
        {
            Console.WriteLine("int sum called");
            return x + y;
        }

        public double sumPrivate(double x, double y)
        {
            Console.WriteLine("double sumPrivate called");
            return x + y;
        }

        public void printName()
        {
            Console.WriteLine("Delegate print Name method called");
        }

    }
}