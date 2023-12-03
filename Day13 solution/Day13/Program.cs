namespace Day13;
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(1,"Sultana" ,19420111 ,"Rustaq" , "Full stack Developer", 122, 5.3);

        Console.WriteLine(emp.ToString());

        emp.Eat();  // inherent from interface to people => employee inhernt from People
    }
}

