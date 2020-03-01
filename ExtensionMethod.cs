using System;
using OOPS;
namespace OOPS
{
    public class Class1
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }
    }
}

namespace MyExtension
{
    public static class Class2
    {
        public static void M2(this Class1 c1)
        {
            Console.WriteLine("Method 2");
        }
    }
}

namespace MyInterface
{
    using System;
    public interface IMyInterface
    {
        void MethodA();
    }
}

namespace Extensions
{
    using System;
    using MyInterface;

    public static class Extension
    {
        public static void MethodB(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension Method B which operate on IMyInterface type with parameter int i");
        }

        public static void MethodB(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension Method B which operate on IMyInterface type with parameter string s");
        }

        public static void MethodA(this IMyInterface myInterface)
        {
            Console.WriteLine("This Method is never be called");
        }
    }
}

namespace ExtensionsDemo
{
    using System;
    using Extensions;
    using MyInterface;

    public class A : IMyInterface
    {
        public void MethodA() { Console.WriteLine("A.MethodB()"); }
    }
 
    public class B : IMyInterface
    {
        public void MethodA() { Console.WriteLine("B.MethodB()"); }
        public void MethodB(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    public class C : IMyInterface
    {
        public void MethodA() { Console.WriteLine("C.MethodB()"); }
        public void MethodB(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }
}


/*
    You can use extension methods to add functionality specific to a particular enum type.
    -> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-create-a-new-method-for-an-enumeration
    

*/