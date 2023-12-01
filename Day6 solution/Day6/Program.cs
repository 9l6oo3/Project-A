namespace Day6;
class Program
{
    static void PrintLine(int length , string pattren , bool flag)
    {
        for (int i = 0; i < length; i++)
        {
            if (flag == true)
                Console.WriteLine(pattren);
            else
                Console.Write(pattren);
        }
    }

    static void swap(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"sawpping  with value complete {x} , {y} ");
    }

    static void swapRef(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"sawpping  with reference complete {x} , {y} ");

    }


    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Enter number of pattren :");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter pattren you want : ");
        string pattren = Console.ReadLine();

        Console.WriteLine("print in new line (false/ true)? ");
        bool flagNew = Convert.ToBoolean(Console.ReadLine());

        PrintLine(n, pattren, flagNew);
        */

        int a = 6;
        int b = 4;

        swap(a, b);
        Console.WriteLine($"in main method the value a {a}, the value of b {b}");
        Console.WriteLine("----------------------------------");
        swapRef(ref a, ref b);
        Console.WriteLine($"in main method the value a {a}, the value of b {b}");

    }

}

