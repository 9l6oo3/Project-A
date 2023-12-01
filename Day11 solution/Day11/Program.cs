namespace Day11;
class Program
{
    static void Main(string[] args)
    {
        #region part1
        //Console.WriteLine("Welcome to our System");
        //Console.WriteLine("Enter your name ");
        //string name = Console.ReadLine();

        //Console.WriteLine("Enter your age ");
        //string sage;
        //int age;
        //do {
        //    sage= Console.ReadLine();

        //} while (!int.TryParse(sage, out age));

        //Console.WriteLine("Enter your Email ");
        //string Email = Console.ReadLine();

        //Console.WriteLine("Enter your address ");
        //string address = Console.ReadLine();

        //Human human1 = new Human(name, age, address, Email);
        //human1.printDetails();
        #endregion

        Human human = new Human ("Sultana",25,"Rustaq","sultana@gmail.com");
        Human human1 = new Human("Sabrin", 25, "Barka", "subrin@gmail.com");
        Console.WriteLine(human.GetId());
        human.SetEmail("sultanabalfoura@gmail.com");
        Console.WriteLine(human.GetEmail());
        Console.WriteLine(human1.GetId());

        Employee employee = new Employee();
        employee.FName = "Sultana";
        Console.WriteLine(employee.FName);


    }
}

