using System;
namespace Day14
{
	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Money { get; set; }

        public User(string Name, int age, double Money)
		{
			this.Name = Name;
			this.Age = age;
			this.Money = Money;
		}

		//overloading operator
		public static double operator +(User a, User b)
		{
			return a.Money + a.Money;
		}

        public static double operator -(User a, User b)
        {
            return a.Money - a.Money;
        }

        public static bool operator ==(User a, User b)
        {
            return a.Money == a.Money;
        }
        public static bool operator !=(User a, User b)
        {
            return a.Money != a.Money;
        }
    }
}

