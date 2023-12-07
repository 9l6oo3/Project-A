namespace Day15;
class Program
{
    public static void print<T>(T value)
    {
        Console.WriteLine(value);
    }

    static void Main(string[] args)
    {
        #region delegete
        //Employee[] emps = new Employee[] {
        //    new Employee{id=1, name="Sultana", gender="f", totalSale=32400},
        //    new Employee{id=2, name="Sabrin", gender="f", totalSale=60333},
        //    new Employee{id=3, name="Shaimaa", gender="f", totalSale=40333},
        //    new Employee{id=4, name="Azza", gender="f", totalSale=20000}
        //};

        //Report rep = new Report();
        //rep.totalSalemorthan60k(emps);
        //rep.totalSalebetween30kand60k(emps);
        //rep.totalSalelessThan30k(emps);


        //Console.WriteLine("After using delegete: \n");

        ////this way will save in momery
        //bool graterThan60k(Employee emp) => emp.totalSale > 60000;
        //bool between30kand60k(Employee emp) => 30000 <= emp.totalSale && emp.totalSale < 59999;
        //bool lessthan30k(Employee emp) => emp.totalSale > 60000;

        //rep.filterSales(emps, "More than 60k", graterThan60k);
        //rep.filterSales(emps, "Between 30 and 60k", between30kand60k);
        //rep.filterSales(emps, "less than 30k", lessthan30k);

        ////this way will not save in momery
        //rep.filterSales(emps, "Female only", (emp/*delegete SalesFilterCondition*/) =>emp.gender == "f");
        #endregion

        #region generic
        print(1);
        print("sultana");
        print(2.3);
        print(true);

        #endregion
    }
}

