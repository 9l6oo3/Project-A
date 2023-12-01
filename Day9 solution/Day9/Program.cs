namespace Day9;
class Program
{
    //static double calculateSalary(int wage, int hour)
    //{
    //    double totalsalary = wage * hour;
    //    return totalsalary;
    //}

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our system!");

        Employee emp = new Employee("Sultana","Balfoura");
        Employee emp2 = new Employee("Shaimaa","al3rami");
        Employee emp3 = new Employee("sabrin","alsaaidi");

        Employee[] employee = { emp, emp2, emp3 };
        for (int i = 0; i < employee.Length; i++)
        {

        }

        //foreach (Employee emplo in employee)
        //{
        //    emplo.id += 1;
        //    Console.WriteLine($"{emplo.id} , {emplo.FName}");
        //}
        //Console.WriteLine($"{emp.id}, {emp.FName} , {emp.LName}");
        //Console.WriteLine($"{emp.id}, {emp.FName} , {emp.LName}");




        Console.WriteLine("Enter Frist name :");
        emp.FName = Console.ReadLine();

        Console.WriteLine("Enter Last name :");
        emp.LName = Console.ReadLine();

        Console.WriteLine("Enter your age ");
        emp.age = int.Parse(Console.ReadLine());

        Console.WriteLine("enter your hour work :");
        emp.hour = int.Parse(Console.ReadLine());

        Console.WriteLine("enter wage: ");
        emp.wage = int.Parse(Console.ReadLine());

        //calculateSalary(emp.wage, emp.hour);

        Console.WriteLine($"Hello {emp.FName}, your age: {emp.age}, your salary {emp.calculateSalary()} OMR");


    }
}

