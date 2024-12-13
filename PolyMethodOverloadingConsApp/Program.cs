//OOPS
//6. Polymorphism
//a. Method Overloading
namespace PolyMethodOverloadingConApp
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
}
