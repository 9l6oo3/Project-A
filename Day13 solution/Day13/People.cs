using System;
namespace Day13
{
	public class People : Creature,INature
	{
		int Id;
		string Name;
		int SSN;
		string Address;

		public People(int id, string name, int SSN, string Address)
		{
			this.Id = id;
			this.Name = name;
			this.SSN = SSN;
			this.Address = Address;
		}

        public override string ToString()
        {
            return $" hello {this.Name} ";
        }

		public void Move()
		{
			Console.WriteLine("I Moving ");
		}
		public void Eat()
		{
			Console.WriteLine("I Eating");
		}
		public void Walk()
		{
			Console.WriteLine("I walking");
		}
    }
}

