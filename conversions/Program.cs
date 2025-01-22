using System;

namespace conversions
{
    public class Conversions
    {
        static void Main(string[] args)
        {
            // can cast variables to other types (if possible)
            int myInt = 10;
            double myIntFromDouble = (double) myInt;
            Console.WriteLine("myIntFromDouble: " + myIntFromDouble);
            
            // can parse strings to other types (if possible)
            string myStringFromInt = "10";
            int myIntFromString = int.Parse(myStringFromInt);
            Console.WriteLine("myIntFromString: " + myIntFromString);
            
            // box and unbox variables
            // use case: you want to store a value type in a reference type and pass it around
            int myBoxedInt = 100;
            object myObject = myBoxedInt; // box the int (basically converting it to an object)
            Console.WriteLine("myObject: " + myObject);
            myBoxedInt = (int) myObject; // unbox the int (basically converting it back to an int)
            Console.WriteLine("myBoxedInt: " + myBoxedInt);
            
            // converting byte array to int
            byte[] bytes = {0, 0, 0, 25};
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            int i = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine("int: {0}", i);
            Console.WriteLine("bytes: {0}", BitConverter.ToString(bytes));
        }
    }
}