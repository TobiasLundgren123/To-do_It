using To_do_It.Models;

namespace To_do_It
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(12, "as", "sdd");
            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person1.LastName);



        }
    }
}