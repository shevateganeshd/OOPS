//OOPS
//7. Inheritance
namespace ConApp
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("This dog barks.");
        }
    }

    //

    public interface IAnimal
    {
        void Speak();
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();  // Output: This animal eats food.
            dog.Bark(); // Output: This dog barks.

            Console.WriteLine();

            IAnimal animal = new Cat();
            animal.Speak(); // Output: Meow.

            Console.ReadKey();
        }
    }
}
