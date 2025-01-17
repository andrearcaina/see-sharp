using System;

namespace controlFlow
{
    public class controlFlow
    {
        static void Main(string[] args)
        {
            int number;
            bool isValidInt = false;
    
            // keep asking for an integer until a valid one is entered
            while (!isValidInt)
            {
                Console.Write("Enter any integer: ");

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("The number " + number + " is even.");
                    }
                    else
                    {
                        Console.WriteLine("The number " + number + " is odd.");
                    }
                    
                    isValidInt = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }

            number = 5;
            
            // ternary operator
            string message = (number > 0) ? "positive" : "non-positive";
            Console.WriteLine("The number " + number + " is " + message + ".");
            
            // switch statement
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero.");
                    break;
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                default:
                    Console.WriteLine("The number is greater than two.");
                    break;
            }
            
            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i: " + i);
            }
            
            // while loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("j: " + j);
                j++;
            }
            
            // do-while loop
            int k = 0;
            do
            {
                Console.WriteLine("k: " + k);
                k++;
            } while (k < 5);
            
            // infinite loop
            // int l = 0;
            // while (l < 5)
            // {
            //     Console.WriteLine("l: " + l);
            // }
            
            // break statement
            for (int m = 0; m < 5; m++)
            {
                if (m == 3)
                {
                    break;
                }
                Console.WriteLine("m: " + m);
            }
            
            // continue statement
            for (int n = 0; n < 5; n++)
            {
                if (n == 3)
                {
                    continue;
                }
                Console.WriteLine("n: " + n);
            }
            
            // nested loop
            for (int o = 0; o < 3; o++)
            {
                for (int p = 0; p < 3; p++)
                {
                    Console.WriteLine("o: " + o + ", p: " + p);
                }
            }
            
            // foreach loop
            string[] fruits = { "apple", "banana", "cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("fruit: " + fruit);
            }
            
            // goto statement
            int q = 0;
            loop: // this is a label
            Console.WriteLine("q: " + q);
            q++;

            if (q < 5)
            {
                goto loop;
            }
            
            
        }
    }
}