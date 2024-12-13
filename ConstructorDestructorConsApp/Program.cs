//OOPS
//9. Constructor and Destructor
namespace ConApp
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
