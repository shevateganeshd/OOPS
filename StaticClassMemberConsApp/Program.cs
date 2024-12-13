//OOPS
//10. Static Class Member
namespace StaticClassMemberConApp
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
}
