using System;
using System.Collections.Generic;

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
            // c1.DescribeCar();  // derived method

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
            // Contact c1 = new Contact("Rahul" , "New Delhi");
            // Console.WriteLine(c1.Name , "-" , c1.Address );
            // Console.WriteLine(c1.Address);
            // c1.Address = "New Delhi";
            //--------------------------------------------------------------------------------




            //-------------------Operators-------------------------------------------------

            // Null conditional operator ?. ?[]
            /*
            * if a evaluates to null, the result of a?.x or a?[x] is null.
            * If a evaluates to non-null, the result of a?.x or a?[x] is the same as the result of a.x or a[x], respectively
            * The null-conditional operators are short-circuiting. That is, if one operation in a chain of conditional member 
              or element access operations returns null, the rest of the chain doesn't execute.
            * Use the ?. operator to check if a delegate is non-null and invoke it in a thread-safe way.
            */

            // Index from end operator ^
            // int[] xs = new[] { 0, 10, 20, 30, 40 };
            // int last = xs[^1];
            // Console.WriteLine(last);


            //----------------------------------------------------------------------------




            //-----------------------destructuring-------------------------------------------------
            // City city = new City();
            // var (_, population, iscapital) = city.getCityInfo();
            // // Console.WriteLine(name);
            // Console.WriteLine(population);
            // Console.WriteLine(iscapital);
            // Person person = new Person("Rahul","Singh","Bisht","New Delhi","New Delhi");
            // var(fname,mName,lName) = person;
            // Console.WriteLine(fname);
            // Console.WriteLine(mName);
            // Console.WriteLine(lName);
            //------------------------------------------------------------------------------------------





            //----------------------------------Indexers---------------------------------------------------
            // DataSamples dataSample = new DataSamples(15);
            // Measurements m =  dataSample[2];
            //---------------------------------------------------------------------------------------------
        }
    }
}

