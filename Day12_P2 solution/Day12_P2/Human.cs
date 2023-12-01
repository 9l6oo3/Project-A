using System;
namespace Day12_P2
{
	public class Human
	{
		public static int Id;
		public string name;
		public bool hasJob;
		public int age;
		public bool isMarried;

		public Human(string name, bool hasJob, int age, bool isMarried)
		{
			Id += 1;
			this.name = name;
			this.hasJob = hasJob;
			this.age = age;
			this.isMarried = isMarried;
		}

		public void describe()
		{
			Console.WriteLine($"ID: {Id} \n,Name: {name} , {hasJob},");
		}

	}
}

