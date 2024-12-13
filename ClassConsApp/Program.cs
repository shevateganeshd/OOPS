//OOPS
//1. Class
namespace ConApp
{
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }

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
}