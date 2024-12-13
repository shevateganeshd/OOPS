//OOPS
//1. Class
/*namespace ConApp
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Mercedez";
            car1.Model = "Classic";
            car1.DisplayInfo();

            Console.ReadKey();
        }
    }
}*/

//2. Object
/*namespace ConApp
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Mercedez";
            car1.Model = "Classic";
            car1.DisplayInfo();

            Console.ReadKey();
        }
    }
}*/

//3. Encapsulation
/*namespace ConApp
{
    public class BankAccount
    {
        private string name;
        private int accountno;
        private double balance;

        public BankAccount(string name, int accountno, double balance)
        {
            this.name = name;
            this.accountno = accountno;
            this.balance = balance;
        }

        public void GetBankAccountDetails()
        {
            Console.WriteLine("Name: " + this.name +
                              " Account No: " + this.accountno +
                              " Balance: " + this.balance);
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Ganesh Shevate",10001,10000);
            BankAccount account2 = new BankAccount("Mangesh Shevate", 10002, 100000);

            account1.GetBankAccountDetails();
            Console.WriteLine("Balance: " + account1.GetBalance());
            account1.Deposit(5000);
            Console.WriteLine("After Deposit 5000");
            account1.GetBankAccountDetails();
            account1.Withdraw(500);
            Console.WriteLine("After Withdrawal 500");
            account1.GetBankAccountDetails();

            Console.WriteLine();

            account2.GetBankAccountDetails();
            Console.WriteLine("Balance: " + account2.GetBalance());
            account2.Deposit(1000);
            Console.WriteLine("After Deposit 1000");
            account2.GetBankAccountDetails();
            account2.Withdraw(500);
            Console.WriteLine("After Withdrawal 500");
            account2.GetBankAccountDetails();
            
            Console.ReadKey();
        }
    }
}*/

//4. Inheritance
/*namespace ConApp
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
}*/


//5. Polymorphism
//a. Method Overloading
/*namespace ConApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
        public float Add(float a, float b) => a + b;
        public string Add(string first, string second)
        {
            return string.Concat(first, second);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Integer Addition : " + calc.Add(2, 3));       // Output: 5
            Console.WriteLine("Double Addition : " + calc.Add(2.5, 3.5));  // Output: 6.0
            Console.WriteLine("Float Addition : " + calc.Add(2.5f, 3.5f));  // Output: 6.0
            Console.WriteLine("Float Addition : " + calc.Add("Ganesh", "Shevate"));  // Output: GaneshShevate

            Console.ReadKey();
        }
    }
}*/

//5. Polymorphism
//b. Method Overriding
/*namespace ConApp
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape | Drawing a shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Cirlce | Drawing a circle.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            shape.Draw(); // Output: Circle | Drawing a circle.

            Shape shape1 = new Shape();
            shape1.Draw(); // Output: Shape | Drawing a circle.

            Circle circle = new Circle();
            circle.Draw(); // Output: Circle | Drawing a circle.

            //Circle circle1 = new Shape();
            //circle1.Draw(); // Output: Drawing a circle.

            Console.WriteLine("Base class Circle reference to Derived class Shape");

            Circle circle2 = new Circle();
            Shape shape3 = circle2;
            shape3.Draw(); // Output: Circle | Drawing a circle.

            Console.ReadKey();
        }
    }
}*/


//6. Abstraction
/*namespace ConApp
{
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding the bike.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Bike();
            vehicle.Drive(); // Output: Riding the bike.

            Console.ReadKey();
        }
    }
}
*/

//7. Inheritance
/*namespace ConApp
{
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
            IAnimal animal = new Cat();
            animal.Speak(); // Output: Meow.

            Console.ReadKey();
        }
    }
}*/

//8. Composition
/*namespace ConApp
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Car
    {
        private Engine engine = new Engine();

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car is running.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.StartCar();
            // Output: Engine started.
            //         Car is running.

            Console.ReadKey();
        }
    }
}*/


//9. Constructor and Destructor
/*namespace ConApp
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public Person(string name, string address, string phoneno, string email)
        {
            Name = name;
            Address = address;
            PhoneNo = phoneno;
            Email = email;
        }
        ~Person()
        {
            Console.WriteLine("Destructor called.");
            Console.ReadKey();
        }
        public void GetPerson()
        {
            Console.WriteLine("Name : "+Name+"\nAddress : "+Address+"\nPhone No : "+PhoneNo+"\nEmail : "+Email);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ganesh Shevate", "Bhuinj", "9096152949", "ganesh.shevate@gmail.com");
            person1.GetPerson();
            
            //Console.ReadKey();
        }
    }
}
*/

//10. Static Class Member
/*namespace ConApp
{
    public static class MathUtils
    {
        public static int Square(int number) => number * number;
        public static float AreaOfTriangle(float baseLength, float height) => 0.5f * baseLength * height;
        public static float AreaOfCircle(float radius) => 3.14f * radius * radius;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square: " + MathUtils.Square(5)); // Output: 25
            Console.WriteLine("Area Of Triangle: " + MathUtils.AreaOfTriangle(11.11f, 22.22f)); // Output: 25
            Console.WriteLine("Area Of Circle: " + MathUtils.AreaOfCircle(55.66f)); // Output: 25
            
            Console.ReadKey();
        }
    }
}*/

namespace ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Console.ReadKey();
        }
    }
}
