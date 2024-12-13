//OOPS
//6. Polymorphism
//b. Method Overriding
namespace PolyMethodOverridingConApp
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
}
