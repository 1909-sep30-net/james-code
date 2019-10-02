using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog;

            try
            {
                dog = new Dog("jusert", -5);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("error");
            }

            //dog.name = "dog";
            dog.Age = -4;
        }
    }
}
