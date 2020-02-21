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

                                           ACCESS MODIFIERS
    *  Struct members cannot be declared as protected because structs do not support inheritance.
    ** Normally, the accessibility of a member is not greater than the accessibility of the type that contains it. However, a public member of an internal
       class might be accessible from outside the assembly if the member implements interface methods or overrides virtual methods that are defined in a
       public base class.
    *  Similarly, the return type and the parameter types of any member that is a method, indexer, or delegate must be at least as accessible as the member
       itself. For example, you cannot have a public method M that returns a class C unless C is also public. Likewise, you cannot have a protected property
       of type A if A is declared as private.
    *  User-defined operators must always be declared as public and static.
    *  Finalizers cannot have accessibility modifiers.
    * Interfaces declared directly within a namespace can be declared as public or internal and, just like classes and structs, interfaces default to 
      internal access. Interface members are always public because the purpose of an interface is to enable other types to access a class or struct.

                                            FIELDS
    * A field can be given an initial value by using the assignment operator when the field is declared.
    * Fields are initialized immediately before the constructor for the object instance is called. If the constructor assigns the value of a field,
      it will overwrite any value given during field declaration.

                                            CONSTANTS
    *  Only the C# built-in types (excluding System.Object) may be declared as const. User-defined types, including classes, structs, and arrays, cannot be const.
      Use the readonly modifier to create a class, struct, or array that is initialized one time at runtime (for example in a constructor) and thereafter cannot be
      changed.
    */
    //--------------------------------------------------------
}