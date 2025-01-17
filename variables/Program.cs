using System;

namespace variables
{
    public class Variables
    {
        static void Main(string[] args)
        {
            var myVar = 10; // var is a type inference keyword, most commonly used with for loop iterators, LINQ queries, and anonymous types (like classes)
            Console.WriteLine("myVar: " + myVar);
            
            // just like Java
            int myInt = 10;
            double myDouble = 10.5;
            char myChar = 'A';
            string myString = "Hello World!";
            bool myBool = true;

            // comments wow
            Console.WriteLine("myInt: " + myInt); // can concatenate strings with +
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