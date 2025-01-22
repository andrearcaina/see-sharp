using System;

namespace variables
{
    public class Variables
    {
        static void Main(string[] args)
        {
            var myVar = 10; // var is a type inference keyword, most commonly used with for loop iterators, LINQ queries, and anonymous types (like classes)
            const int myConst = 10; // const is a keyword that makes a variable immutable
            myVar = 20; // this is allowed
            // myConst = 20; // this is not allowed
            Console.WriteLine("myVar: " + myVar);
            Console.WriteLine("myConst: " + myConst);
            
            short myShort = 10; // this is a signed integer of length 16 bits
            ushort myUShort = 10; // this is an unsigned integer of length 16 bits
            int myInt = 10; // this is a signed integer of length 32 bits
            uint myUInt = 10; // this is an unsigned integer of length 32 bits
            long myLong = 10; // this is a signed integer of length 64 bits
            ulong myULong = 10; // this is an unsigned integer of length 64 bits
            float myFloat = 10.5f; // this is a single-precision floating point number
            double myDouble = 10.5; // this is a double-precision floating point number
            char myChar = 'A'; // this is a single Unicode character
            string myString = "Hello World!"; // this is a sequence (or array) of characters
            bool myBool = true; // this is a boolean value

            // comments wow
            Console.WriteLine("myShort: " + myShort);
            Console.WriteLine("myUShort: " + myUShort);
            Console.WriteLine("myInt: " + myInt); // can concatenate strings with +
            Console.WriteLine("myUInt: " + myUInt);
            Console.WriteLine("myDouble: " + myDouble);
            Console.WriteLine(string.Format("myChar: {0}", myChar)); // or format strings with string.Format
            Console.WriteLine($"myString: {myString}"); // or format strings with string interpolation ($)
            Console.WriteLine($"myBool: {myBool}");
            
            // C# is statically typed, so you can't change the type of a variable
            // myInt = "Hello World!"; // this will not compile
            
            // finite collections of variables can be stored in arrays or lists
            int[] myIntArray = {1, 2, 3, 4, 5};
            string[] myStringArray = {"one", "two", "three", "four", "five"};
            
            // arrays are zero-indexed
            Console.WriteLine("myIntArray[0]: " + myIntArray[0]);
            Console.WriteLine("myStringArray[1]: " + myStringArray[1]);
            
            // later on there will be more complex data structures like dictionaries and lists that are more flexible
        }
    }
}