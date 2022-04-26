using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        public class Animal
        {
            public void eat()
            {
                Console.WriteLine("Animal is eating...");
            }

            public void makeSound()
            {
                Console.WriteLine("Animal is making sound...");
            }
        }

        public class Cat : Animal
        {
            public void run()
            {
                Console.WriteLine("cat is running..");
            }
        }

        public class Bird: Animal
        {
            public void fly()
            {
                Console.WriteLine("bird is flying...");
            }
        }
        
        static void Main(string[] args)
        {
        }
    }
}
