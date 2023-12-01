namespace Day3;

class Program
{
    static void Main(string[] args)
    {
        
        //ternary operator
        Console.Write("Enter number : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((x % 3 == 0) ? "is divisibale by 3" : "is not divisibale by 3");

        int y = 6;
        int z = 5;

        //logical operator
        Console.WriteLine((z > y) && (y == z));         // False
        Console.WriteLine((z < y) || (y > z));          //True
        Console.WriteLine(z!=y);                        //True
        Console.WriteLine((z<y) ^ (y<z));               //True
        
    }
}

