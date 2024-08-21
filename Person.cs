namespace RoutingProj
{
    public class Person
    {
        public static IList<Person> All { get; set; }

        static Person()
        {
            All = new List<Person>() {
            new Person() { Name = "Sergey", Age = 40, Id=1 },
            new Person() { Name = "Anna", Age = 20, Id = 2 },
            new Person() { Name = "Boris", Age = 10, Id = 3 },
            };
        }

        public string Name { get; set; }    
        public int Age { get; set; }
        public int Id { get; set; }

    }
}
