namespace Day18;
class Program
{
    static void Main(string[] args)
    {
        //extension method 
        //int x = 12345;
        //Console.WriteLine(x.Miror());


        List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = lst.Where( x => x % 2 != 0);
        //List<int> result = lst.Where(x => x % 2 != 0).ToList();
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
        //add new elements in list

        Console.WriteLine("------------------------------------------------------------");
        // it's Enumarable type
        // to stop Enumarable => add .toList() in where condition
        //var result = lst.Where( x => x % 2 != 0).ToList(); => now will stop connection 
        lst.AddRange(new int[] { 10, 11, 12, 13, 14 });
        lst.Remove(2);
        foreach (var item in lst)
        {
            Console.WriteLine($"{item}");
        }

    }
}

