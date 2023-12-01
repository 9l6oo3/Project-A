namespace Day12;
class Program
{
    static void Main(string[] args)
    {
        PhoneBook newPhone = new PhoneBook(5);
        newPhone.add("Sultana", 663928876);
        newPhone.add("Sabrin", 663900018);
        newPhone.add("Shaima", 661111122);

        newPhone.GetAll();

        Console.WriteLine(newPhone.GetNum("Sabrin"));
        newPhone.EditNum("Subrin", 98754689);
        newPhone.GetAll();


        Console.WriteLine("-------- indexer section --------");
        Console.WriteLine(newPhone["Sultana"]);
        newPhone["Skeikha"] = 9467781;
        Console.WriteLine(newPhone["Skeikha"]);
        newPhone.GetAll();
    }
}

