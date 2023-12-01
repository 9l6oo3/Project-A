using System;
using System.Xml.Linq;

namespace Day12_P2
{
	public class Employee :Human
	{
		string role;
		string department;
		int workingHours;
        int wage;

		public Employee(string role, string department, int workHour, int wage, string name, bool hasJob, int age, bool isMarried) :base( name,  hasJob,  age,  isMarried)
		{
			this.role = role;
			this.department = department;
			this.workingHours = workHour;
			this.wage = wage;
		}

		public double salary(int wage, int workingHours)
		{
			double totalSalary = wage * workingHours;
			return totalSalary;
		}

        public void EmployeeInfo()
        {
            Console.WriteLine($"ID: {Id} \n,Name: {name} , {hasJob}, {department} , {workingHours}, {wage} , {isMarried}");
			Console.WriteLine(salary(wage, workingHours));
        }
    }
}

