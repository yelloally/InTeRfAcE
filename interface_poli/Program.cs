using System;
namespace interface_poli
{
    //implements the interface
    class Dog : IAnimal
    {
        private string breed;

        public Dog(string breed)
        {
            this.breed = breed;
        }

        //method which returns the sound which made doGs
        public void makeSound()
        {
            Console.WriteLine("The " + breed + " dog says woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What breed is your dog?");
            string breed = Console.ReadLine();

            IAnimal myAnimal = new Dog(breed);

            myAnimal.makeSound();

            Console.ReadKey();
        }
    }
}