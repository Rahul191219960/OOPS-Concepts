using System;
namespace OOPS
{
    public  class employeee
    {
        protected employeee()
        {
            Console.WriteLine("Base Employee Contructor of employee");
        }

        public string firstName = "First Name";
        public string lastName = "Last Name";
        protected employeee(string message)
        {
            Console.WriteLine("Base Overloded Constructor of employee " + message + firstName + lastName);
        }
        public virtual void printName()
        {
            Console.WriteLine("abstract class employee printName()");
        }
    }

    public class partTimeEmployee : employeee
    {
        public new string firstName = "partTime FirstName";
        public partTimeEmployee() : base("Hello")
        {
            Console.WriteLine("Part Time Constructor" + firstName + lastName);
        }
        public override void  printName()
        {
            Console.WriteLine("Part Time Employee printName()" + firstName + lastName);
        }
    }

    public class fullTimeEmployee : partTimeEmployee
    {
        public fullTimeEmployee()
        {
            Console.WriteLine("Full time constructor fullTimeEmployee()");
        }
    }
}