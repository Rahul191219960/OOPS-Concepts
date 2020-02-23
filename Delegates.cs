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

        public void printName1()
        {
            Console.WriteLine("Delegate print 1 Name method called");
        }
        public void printName2()
        {
            Console.WriteLine("Delegate print 2 Name method called");
        }
        public void printName3()
        {
            Console.WriteLine("Delegate print 3 Name method called");
        }

    }
}