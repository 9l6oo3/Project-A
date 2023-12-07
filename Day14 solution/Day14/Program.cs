namespace Day14;

enum Months
{
    jan=1,
    feb,
    mar,
    apr,
    may,
    jun,
    jul,
    aug,
    sep,
    oct,
    nov,
    dec
}


[Flags]
enum permissions
{
    None = 0,
    write =1,
    read=2,
    delete=4,
    excute =8
}

class Program
{
    static void Main(string[] args)
    {
        //string month = "feb";
        //Console.WriteLine(Enum.Parse(typeof(Months), month));


        User user1 = new User("Sultana" , 25, 2000);
        User user2 = new User("Sabrin" , 25, 2000);

        Console.WriteLine(user1 + user2);
        Console.WriteLine(user1 - user2);
        Console.WriteLine(user1 == user2);
        Console.WriteLine(user1 != user2);
    }
}

