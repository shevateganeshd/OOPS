//OOPS
//8. Composition
namespace CompositionConApp
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
}
