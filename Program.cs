using System;

namespace OOPS
{

    delegate int sumDelegate(int x, int y);
    delegate double sumPrivateDelegate(double x, double y);
    delegate void printDelegate();
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
            // CountInstances c1 = new CountInstances();
            // CountInstances c2 = new CountInstances();
            // CountInstances c3 = new CountInstances();
            // CountInstances c4 = new CountInstances();
            // Console.WriteLine(CountInstances.countNoOfInstances); // with static counter
            // Console.WriteLine(c4.countNoOfInstances); // without static counter
            //---------------------------------------------------------------------------




            //--------------------Delegates-------------------------------------------------
            // delegates d1 = new delegates();
            // sumDelegate sumvar = d1.sum;
            // sumPrivateDelegate sum1var = d1.sumPrivate;

            // int Result = sumvar(1, 3);
            // Console.WriteLine(Result);
            // Console.WriteLine(sum1var(4.5, 5.2));

            // printDelegate printvar = d1.printName;
            // printDelegate printvar1 = d1.printName1;
            // printDelegate printvar2 = d1.printName2;
            // printDelegate printvar3 = d1.printName3;
            // printDelegate allMethods = printvar + printvar1 + printvar2 + printvar3;
            // printDelegate allMethods = printvar + printvar1 + printvar2 - printvar3;
            // allMethods();
            //------------------------------------------------------------------------------



            
            //---------------------Immutable Classes------------------------------------------
            Contact c1 = new Contact("Rahul" , "New Delhi");
            // Console.WriteLine(c1.Name , "-" , c1.Address );
            // Console.WriteLine(c1.Address);
            // c1.Address = "New Delhi";
            //--------------------------------------------------------------------------------
        }
    }
}

