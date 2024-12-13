//OOPS
//7. Abstraction
namespace AbstractionConApp
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
