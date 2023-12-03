using System;
namespace Day13
{


	public class Employee : People
	{
		string role;
		int workingHours;
		double wage;

		public Employee(int id, string name, int SSN, string Address, string role, int workingHours , double wage) :base( id,name, SSN, Address)
		{
			this.role = role;
			this.workingHours = workingHours;
			this.wage = wage;
		}
		
        public override string ToString()
        {
            return base.ToString() + $"your Position {this.role} and your total Salary is : {totalSalary()} OMR";
        }

		public double totalSalary()
		{
			return workingHours * wage;
		}
    }
}

