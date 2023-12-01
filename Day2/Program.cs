namespace Day2
{
    class Progam
    {
        static void Main()
        {

            //Identify and Initializing variables
            //<datatype> <variablename> = <value> ;

            string FullName = "Sultana Balfoura" , job = "Full stack developer trainee";
            //string job = "Full stack developer trainee ";
            
            int age = 25;


            //print massage with space and calling variables 
            Console.WriteLine(" FullName :" + FullName + "\n job :" + job + "\n age : " + age);


            Console.WriteLine("hello there \n" +
                "\t I am in patch 3");



            //one line comment
            /* 
             
             multi line comments
             
             */


            //identify double, float, and decimal
            double payment = 3.45;
            float money = 44.5f;
            decimal salary = 3.4m;


            //checked & unchecked Bolck

            // checked block

            /*checked
            {
                long x = 1234587653;
                int update = int(x);

            }*/

            int intMax = int.MaxValue;
            Console.WriteLine("Max integer : " + (intMax + 2));

            checked
            {
                intMax = int.MaxValue;
                Console.WriteLine("Inside checked Block : " + (intMax + 1));
            }

            unchecked
            {
                intMax = int.MaxValue;
                Console.WriteLine("Inside unchecked Block: " + intMax + 2);
            }





            //identify object and print referece in heap
            Object obj1 = new Object();
            Object obj2 = new Object();
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            obj1 = obj2;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);



        }

    }
}