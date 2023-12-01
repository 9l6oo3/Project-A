using System;
namespace Day11
{
	public class Employee
	{
		int id;
		string fname;
		string lastname;
		string address;


		public int ID
		{
			get { return id; }
			set { this.id = value; }
		}

		public string FName
		{
			get { return fname; }
			set { this.fname = value; }
		}

		public Employee()
		{
		}
	}
}

