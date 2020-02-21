using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------abstract class code and polymorphism--------------------
            // partTimeEmployee pte = new partTimeEmployee();
            // partTimeEmployee pte1 = new fullTimeEmployee();
            // employeee[] employeees= new employeee[3];
            // employeees[0] = new partTimeEmployee();
            // employeees[1] = new fullTimeEmployee();
            //-------------------------------------------------------------------------




            //------------------------method overlodaing--------------------------------
            // student std = new topper();
            // std.studentName = "Mark";
            // int marks = std.totalMarks(89,99);
            // Console.WriteLine(marks);
            //--------------------------------------------------------------------------




            //----------------------------structures------------------------------------
            // Structure S1;
            // S1.first = "Hello";
            //--------------------------------------------------------------------------




            //-----------------------polymorphism---------------------------------------
            // Console.WriteLine("*******************************polymorphism *******************************");
            // Console.WriteLine("---convertible---");
            // ConvertibleCar c1 = new ConvertibleCar();
            // c1.ShowDetails();  // derived method

            // Console.WriteLine("--mini van-------");

            // Minivan c2 = new Minivan();
            // c2.DescribeCar();

            // Console.WriteLine("-- car with convertible reference--");
            // Car c3 = new ConvertibleCar();
            // c3.ShowDetails();
            //--------------------------------------------------------------------------




            //--------------------static keyword-----------------------------------------
            CountInstances c1 = new CountInstances();
            CountInstances c2 = new CountInstances();
            CountInstances c3 = new CountInstances();
            CountInstances c4 = new CountInstances();
            Console.WriteLine(CountInstances.countNoOfInstances); // with static counter
            // Console.WriteLine(c4.countNoOfInstances); // without static counter
            //---------------------------------------------------------------------------
        }
    }
}
