using System;
namespace OOPS
{
    public class CountInstances
    {
        public static int countNoOfInstances = 0;
        public CountInstances()
        {
            countNoOfInstances += 1;
        }
    }

    // --------------- points to remember --------------------
    /*
                                            STATIC CLASSES
    * A static class can be used as a convenient container for sets of methods that just operate on input parameters and
       do not have to get or set any internal instance fields.
    * A static constructor is only called one time, and a static class remains in memory for the lifetime of the
      application domain in which your program resides.
    * Main features of static class are Contains only static members, Cannot be instantiated, Is sealed
      and  Cannot contain Instance Constructors  "instance constructor is yet to come".
    
                                            STATIC MEMBERS
    * The static member is callable on a class even when no instance of the class has been created. 
    * The static member is always accessed by the class name, not the instance name.
    * Only one copy of a static member exists, regardless of how many instances of the class are created.
    * Static methods and properties cannot access non-static fields and events in their containing type,
      and they cannot access an instance variable of any object unless it is explicitly passed in a method parameter.
    * Two common uses of static fields are to keep a count of the number of objects that have been instantiated,
      or to store a value that must be shared among all instances.
    * Static methods can be overloaded but not overridden, because they belong to the class, and not to any instance of the class.
    * C# does not support static local variables (variables that are declared in method scope).
    * Static members are initialized before the static member is accessed for the first time and before the static constructor,
      if there is one, is called. To access a static class member, use the name of the class instead of a variable name to specify the location of the member.

    */
    //--------------------------------------------------------
}