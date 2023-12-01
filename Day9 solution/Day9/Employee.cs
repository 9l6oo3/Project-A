using System;
namespace Day9
{
	public class Employee
	{
		public string FName;
		public string LName;
		public int id;
		public int age;
		public int wage;
		public int hour;


	

		public Employee(string _FName, string _LName)
		{
            FName = _FName;
			LName = _LName;
		}


        public double calculateSalary()
        {
            double totalsalary = this.wage * this.hour * 0.3;
            return totalsalary;
        }
    }
}

