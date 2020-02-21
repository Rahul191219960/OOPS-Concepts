using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS
{
    public class Car
    {
        public virtual void DescribeCar()
        {
            System.Console.WriteLine("Four wheels and an engine.");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Standard transportation.");
        }
    }

    // Define the derived classes.  

    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
    // hides the base class method.  
    public class ConvertibleCar : Car
    {
        public new void ShowDetails()
        {
            System.Console.WriteLine("A roof that opens up.");
        }
    }

    // Class Minivan uses the override modifier to specify that ShowDetails  
    // extends the base class method.  
    public class Minivan : Car
    {
        public override void ShowDetails()
        {
            System.Console.WriteLine("Carries seven people.");
        }
    }

    //------points to remember-----------
    /*
    * if we use new keyword in derived class then the method which is called in the base class could not able to call the 
     new implementation of the derived in the derived class.
    */
}

