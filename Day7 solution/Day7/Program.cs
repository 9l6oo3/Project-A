namespace Day7;
class Program
{

    static int sumArray(params int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static bool testOut(int x , out int y)
    {
        y = 0;
        if (x != y)
        {
            return false;
        }
        else
        {
            return true;
        }
    } 


    static bool multiplayAndSum(out int multi, out int sum, params int[] arr)
    {
        
            if (arr.Length >= 1)
            {
            sum = 0;
            multi = arr[0] * arr[1];
                for (int i = 0; i < arr.Length; i++)
                {
                
                sum += arr[i];
                }
            return true;
            }
            else
            {
                sum = 0;
                multi = 0;
                return false;
            }

    }

        //int sum = 0;
        //y = 0;
        //int multi = x* y;
        ////arr = new int[];
        //return multi;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    sum += arr[i];
        //}
        //return sum;

    


    static void Main(string[] args)
    {
        int mult = 0;
        int sum = 0;
        //Console.WriteLine(multiplayAndSum(1,out x,2,5,4,5));
        //Console.WriteLine(testOut(3,out x));
        Console.WriteLine(multiplayAndSum(out mult,out sum, 1));

    }
}

