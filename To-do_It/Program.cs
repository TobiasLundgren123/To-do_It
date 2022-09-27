using To_do_It.Data;
using To_do_It.Models;

namespace To_do_It
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("as", "sdd");
            //Console.WriteLine(person1.FirstName);
            //Console.WriteLine(person1.LastName);
            //Console.WriteLine(person1.id);

            //Person person2 = new Person("cvdddd", "vccvvvvv");
            //Console.WriteLine(person2.FirstName);
            //Console.WriteLine(person2.LastName);
            //Console.WriteLine(person2.id);

            //Todo todo1 = new Todo(100, "Program C#");
            //todo1.Assignee = person1;
            //todo1.Done = false;
            //Console.WriteLine("Id " + todo1.Id + " description: " + todo1.Description + " assignee " + todo1.Assignee + " done:" + todo1.Done);

            PeopleService peopleList = new PeopleService();
            peopleList.newPerson("John", "Lennon");
            peopleList.newPerson("George", "Harrison");
            peopleList.newPerson("Ringo", "Paul");

            //foreach (Person person in peopleList)
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.id);
            //}

            Person person21 = new Person("new", "person", 21);


            Console.WriteLine(peopleList.FindAll());

            TodoService todoService = new TodoService();
            todoService.newTodo("clean everything", person21);
            todoService.newTodo("burn evidence", person21);





        }
    }
}