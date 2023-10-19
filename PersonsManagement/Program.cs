namespace PersonsManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(
                "Doe",
                "John",
                new DateTime(1990, 10, 19),
                new Address("Romania", "Ilfov", "Bucharest", "Republicii", "10"));

            Person p2 = new Person(
                "Marry",
                "Joe",
                new DateTime(1986, 8, 20),
                new Address("Romania", "Cluj", "Cluj-Napoca", "Horea", "17"));

            PersonConsolePrinter.Print(p1);
            Console.WriteLine();
            PersonConsolePrinter.Print(p2);
        }
    }
}