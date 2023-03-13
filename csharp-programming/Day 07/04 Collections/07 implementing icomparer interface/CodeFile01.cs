using System.Net.Cache;

namespace csharp_programming
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "Gopal", Age = 25 },
                new Person() { Name = "vikram", Age = 20 },
                new Person() { Name = "Shweta", Age = 23 },
            };

            people.Sort(new PersonComparer());

            //acccess the sorted list
            foreach(Person p in people)
            {
                Console.WriteLine("{0} ({1} years old)",p.Name,p.Age);
            }
        }
    }
}