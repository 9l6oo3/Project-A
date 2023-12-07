using System;
namespace Day15
{
	public class Report
	{
		public void totalSalemorthan60k(Employee[] emp)
		{
			Console.WriteLine("report for emloyees total sales more than 60k");
            Console.WriteLine("-------------------------------------");
			foreach (Employee e in emp)
			{
				if (e.totalSale >= 60000)
				{
					Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.totalSale}");
				}
			}
            Console.WriteLine("\n\n");
        }

        public void totalSalebetween30kand60k(Employee[] emp)
        {
            Console.WriteLine("report for emloyees total sales between 30k and 60k");
            Console.WriteLine("-------------------------------------");
            foreach (Employee e in emp)
            {
                if (30000 <= e.totalSale && e.totalSale < 59999)
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.totalSale}");
                }
                
            }
            Console.WriteLine("\n\n");
        }

        public void totalSalelessThan30k(Employee[] emp)
        {
            Console.WriteLine("report for emloyees total sales less than 60k");
            Console.WriteLine("-------------------------------------");
            foreach (Employee e in emp)
            {
                if (30000 > e.totalSale)
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.totalSale}");
                }
                
            }
            Console.WriteLine("\n\n");

        }


        //delegete function 
        public delegate bool SalesFilterCondition(Employee emp);

        public void filterSales(Employee[] emp, string title , SalesFilterCondition cond/*reference*/)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------------");
            foreach (Employee e in emp)
            {
                if (cond(e)/*if true will excute*/)
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.totalSale}");
                }

            }
            Console.WriteLine("\n\n");

        }

    }
}

