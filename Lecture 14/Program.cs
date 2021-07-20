using System;

namespace Lecture_14
{
    class Program
    {
        static void Main(string[] args)
        {
           // encapsulation
           // inheritance
           // abstraction
           // polymorphism
           
           Animal myAnimal = new Animal();  // Create a Animal object
           Animal myPig = new Pig();  // Create a Pig object
           Animal myDog = new Dog();  // Create a Dog object

           myAnimal.AnimalSound();
           myPig.AnimalSound();
           myDog.AnimalSound();
        }
    }
    
    class Animal  // Base class (parent) 
    {
        public virtual void AnimalSound()
        {
            
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void AnimalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
