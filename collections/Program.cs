using System;

namespace collections
{
    public class Collections
    {
        static void Main(string[] args)
        {
            // finite collections
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Numbers");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // functions to manipulate the array
            Console.WriteLine("Total number of elements in the array: " + numbers.Length);
            Array.Reverse(numbers);
            Array.Sort(numbers);
            Array.Clear(numbers, 0, numbers.Length); // array, index, length
            
            Console.WriteLine("Numbers after manipulation");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // multi-dimensional arrays (still finite)
            // 2D array where each array can't have different lengths (unlike jagged arrays)
            int[,] matrix = new int[2, 3]; // 2 rows, 3 columns
            // or can define like
            int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            
            Console.WriteLine("Multi-dimensional Arrays");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            // jagged arrays (still finite)
            // jagged arrays are arrays of arrays (where each array can have different lengths)
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6 };

            Console.WriteLine("Jagged Array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            // jagged arrays are more flexible
            Console.WriteLine("Jagged Array 2");
            int[][] jaggedArray2 = new int[3][];
            jaggedArray2[0] = new int[] { 1, 2, 3 };
            jaggedArray2[1] = new int[] { 4, 5 };
            jaggedArray2[2] = new int[] { 6, 7, 8, 9 };
            
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            // dynamic collections (that is part of the base class library)
            List<int> numbersList = new List<int>();
            
            for (int i = 0; i < 5; i++)
            {
                numbersList.Add(i);
            }
            
            Console.WriteLine("Total number of elements in the list: " + numbersList.Count);
            
            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // functions to manipulate the list
            numbersList.RemoveAt(0);
            numbersList.RemoveAt(numbersList.Count - 1);
            numbersList.Insert(0, 5); // index, value
            numbersList.Add(5);
            
            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // dictionaries (key-value pairs)
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("USA", "United States of America");
            countries.Add("UK", "United Kingdom");
            countries.Add("IN", "India");
            
            Console.WriteLine("Total number of elements in the dictionary: " + countries.Count);
            
            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine(country.Key + ": " + country.Value);
            }
            
            // functions to manipulate the dictionary
            countries.Remove("UK");
            countries["IN"] = "Republic of India"; // update value for key "IN" to "Republic of India"
            
            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine(country.Key + ": " + country.Value);
            }
            
            // queues (FIFO)
            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(1);
            numbersQueue.Enqueue(2);
            numbersQueue.Enqueue(3);
            
            Console.WriteLine("Total number of elements in the queue: " + numbersQueue.Count);
            
            foreach (int number in numbersQueue)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // functions to manipulate the queue
            numbersQueue.Dequeue(); // remove the first element
            numbersQueue.Enqueue(4); // add an element to the end
            
            foreach (int number in numbersQueue)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // stacks (LIFO)
            Stack<int> numbersStack = new Stack<int>();
            numbersStack.Push(1);
            numbersStack.Push(2);
            numbersStack.Push(3);
            
            Console.WriteLine("Total number of elements in the stack: " + numbersStack.Count);
            
            foreach (int number in numbersStack)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // functions to manipulate the stack
            numbersStack.Pop(); // remove the first element (removed from the top of the stack)
            numbersStack.Push(4); // add an element to the end (added to the top of the stack)
            
            foreach (int number in numbersStack)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // sets (unique elements)
            HashSet<int> numbersSet = new HashSet<int>();
            numbersSet.Add(1);
            numbersSet.Add(2);
            numbersSet.Add(3);
            
            Console.WriteLine("Total number of elements in the set: " + numbersSet.Count);
            
            foreach (int number in numbersSet)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // functions to manipulate the set
            numbersSet.Remove(2); // remove an element
            numbersSet.Add(4); // add an element

            foreach (int number in numbersSet)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // linked lists (doubly linked list)
            LinkedList<int> numbersLinkedList = new LinkedList<int>();
            numbersLinkedList.AddLast(1); // add an element to the end
            numbersLinkedList.AddLast(2);
            numbersLinkedList.AddLast(3);
            
            Console.WriteLine("Total number of elements in the linked list: " + numbersLinkedList.Count);
            
            foreach (int number in numbersLinkedList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            // functions to manipulate the linked list
            numbersLinkedList.RemoveFirst(); // remove the first element
            numbersLinkedList.AddFirst(4); // add an element to the beginning

            foreach (int number in numbersLinkedList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}