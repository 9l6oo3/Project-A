namespace Day4;
class Program
{
    static void Main(string[] args)
    {

        int i;
        //1-Dimensional Array
        string[] names = new string[3] { "Sultana", "Sabrin", "Sheikha" };

        for(i=0; i<names.Length; i++)
        {
            Console.WriteLine("Name : " + names[i]);
        }


        //multi Dimensional Array
        int[,] marks = new int[2,2];
        marks[0, 0]= 89;
        marks[0, 1]= 99;
        marks[1, 0]= 79;
        marks[1, 1]= 98;

        //print elements in multi-dimensional array
        for (i = 0; i <marks.GetLength(0); i++)
        {
            for (int j = 0; j < marks.GetLength(1); j++)
            {
                Console.WriteLine(marks[i, j]);
            }
        }


        //Jagged Array
        int[][] tryJagged = new int[2][];
        tryJagged[0] = new int[2] { 2, 4 };
        tryJagged[1] = new int[3] { 3, 2, 5 };

        for (i = 0; i < tryJagged.Length; i++)
        {
            for (int j = 0; j < tryJagged[i].Length; j++)
            {
                Console.WriteLine(tryJagged[i][j]);
            }
        }



    }
}

