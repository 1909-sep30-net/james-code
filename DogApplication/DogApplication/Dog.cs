using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        //access modifiers
        //public acces - everyone can see
        //internal - everyone in the same assembly (project) can see.
        //protected - everyone who is a subclass of Dog can see (even if it is in another project).
        //private - only this class can see.

        //for class members, default is private

        //constructor

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
                //an exception is how we handle "errors" during runtime
        }

        //fields
        private string name;

        //public int Age { get; set; }
        //^ this is an "auto-property" -
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                age = value;
            }
        }
        
    }
}
