using System;

namespace objects
{
    public class Objects
    {
        static void Main(string[] args)
        {
            /*
             an object is an instance of a class (a blueprint)
             objects have properties (attributes) and methods (functions)
             objects can be created from classes
             objects can be passed as arguments to functions
             objects can be returned from functions
             objects can be stored in collections
            */
            
            // create an object with properties
            Person person1 = new Person("Alice", 30, true);
            
            // can create multiple objects from the same class with different properties
            Person person2 = new Person("Bob", 25, true);
            Person person3 = new Person("Charlie", 35, false);
            Person person4 = new Person("Eve", 20, false);
            
            // can create objects without assigning them to variables
            new Person("David", 40, false).SayHello();
            Console.WriteLine();
            
            // can store objects in arrays
            Person[] people = { person1, person2, person3, person4 };
            
            foreach (Person person in people)
            {
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Age: " + person.Age);
                Console.WriteLine("Employed: " + person.GetEmployed());
                person.SayHello();
                person.SayAge();
            }
            Console.WriteLine();
            
            // can create a dynamic collection of objects
            List<Person> peopleList = new List<Person>();
            peopleList.Add(person2);
            peopleList.Add(person4);
            
            foreach (Person person in peopleList)
            {
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Age: " + person.Age);
                Console.WriteLine("Employed: " + person.GetEmployed());
                person.SayHello();
                person.SayAge();
            }
            Console.WriteLine();
            
            // can set properties with set
            person1.Name = "Anna";
            person1.Age = 50;
            person1.SetEmployed(false);
            
            Console.WriteLine("Name: " + person1.Name);
            Console.WriteLine("Age: " + person1.Age);
            Console.WriteLine("Employed: " + person1.GetEmployed());
            // method overloading
            person1.SayAge();
            person1.SayAge(50);
            
            // enum is a type that consists of a set of named constants
            int day1 = (int)Days.Monday; // gets the integer value of Monday (which is the index of Monday in the enum)
            Days day2 = Days.Tuesday; // gets the enum value of Tuesday
            Console.WriteLine("Day: " + day1);
            Console.WriteLine("Day: " + day2);
        }
    }
}