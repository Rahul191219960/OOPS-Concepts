using System;
namespace OOPS
{
    public struct Structure
    {
        public string first ;
        public int second ;

        public void printFirst()
        {
            Console.WriteLine(" Structure printName()");
        }
    }

    public interface I1
    {
        void printNameI1();
    }

    public interface I2
    {
        void printNameI2();
    }
    public struct Structure1 : I1, I2
    {
        public string first { get; }
        public string second { get; set; }


        // !!!! uncomment this to see error 
        // public Structure1(string message) 
        // {
        //     Console.WriteLine("Structure's constructor")
        // }

        // it happens because Within a struct declaration, fields cannot be initialized unless they are declared as const or static.
        /*
            matlab pehele hi agar maine parameterize constructor chala diya jaise ki Structue1 s1 = new Structure1("hello") toh rule k according structs ki field 
            toh initalised nahi ho sakti hai toh agar main parameterize conatructor main field inialized kr rha hou kya pya compiler ko toh woh erroe seta hai
            to agar auto implemented property hai toh hume pehele default constructor chalana padega taki obect ban jaye structure ka uske baad parameterize constructore chale
        */

        // corrected code

        public Structure1(string message) : this()
        {
            Console.WriteLine("Structure's constructor");
        }
        public void printNameI1()
        {
            Console.WriteLine("I1 interface implementation");
        }
        public void printNameI2()
        {
            Console.WriteLine("I1 interface implementation");
        }
        public void printFirst()
        {
            Console.WriteLine(" Structure printName()");
        }
    }

}

/*

            IMPORTANT POINTS TO REMEMBER

* structure are value type but classes are reference type
* value type are stired in stack but reference types are stored in heaps
* refrences are deleted by garbage collector
* structure can inherit only interface
* structure can inherit multiple structures
* ek structure mai badalenge to agle mai bhi change hoga jaise ki pointer mai hota hai jab 2 pointer ek array ko point krte hai.
  this is important to remember when working with collections of value types such as Dictionary<string, myStruct>.
* Unlike classes, structs can be instantiated without using the new operator. In such a case, there is no constructor call, 
  which makes the allocation more efficient. However, the fields will remain unassigned and the object cannot be used until all
  of the fields are initialized. This includes the inability to get or set values through properties.
* If you instantiate a struct object using the parameterless constructor, all members are assigned according to their default values.
* structures cannot be the base of a class.
* All structs inherit directly from ValueType, which inherits from Object.
* A struct cannot be null, and a struct variable cannot be assigned null unless the variable is declared as a nullable value type.
* 


-> misc https://www.telerik.com/blogs/implementing-indexers-in-c
*/
