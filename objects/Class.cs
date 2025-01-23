using System;

namespace objects
{
    public class Person
    {
        // fields
        private string name;
        private int age;
        private bool employed;
        
        // properties
        // C# makes it so that we can access the properties directly with get and set (no logic needed)
        // properties are like fields but with get and set methods
        // short way to write properties is: public string Name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age cannot be negative");
                }
                age = value;
            }
        }

        // fields and properties are similar but properties have get and set methods 
        // properties are used to control access to fields
        // properties are used to validate fields
        // fields are used to store data, as they are usually private
        // fields are like variables, while properties are another layer of abstraction for fields that encapsulate them
        
        // constructor
        public Person(string name, int age, bool employed = false)
        {
            Name = name;
            Age = age;
            this.employed = employed;
        }
         
        // getter and setter methods (more complex get and set)
        public bool GetEmployed()
        {
            return employed;
        }
        
        public void SetEmployed(bool employed)
        {
            this.employed = employed;
        }
            
        // methods
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }

        public void SayAge()
        {
            Console.WriteLine("I am " + Age + " years old");
        }
        
        // method overloading
        public void SayAge(int years)
        {
            Console.WriteLine("In " + years + " years, I will be " + (Age + years) + " years old");
        }
    }
}