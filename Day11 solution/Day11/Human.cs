using System;
namespace Day11
{
	public class Human
	{
		private int id;
		public static int _id;
		public string name;
		public string address;
        private string email;
		public int age;

		public Human() { }

		public Human(string name, int age , string address, string email)
		{
			id = ++_id;
			//_id +=1;
			//id = _id;
			this.name = name;
			this.age = age;
			this.address = address;
			this.email = email;

		}

		public string printDetails() => $"{this.name} \n your age {this.age} \n your email {this.email}";
		//public string printDetails()
		//{
		//	return $"{this.name} \n your age {this.age} \n your email {this.email}";

  //      }

		//getter id 
		public int GetId() => id;

		//setter and getter Email
		public string GetEmail() => email;
        public void SetEmail(string Email) => this.email = Email;

    }
}

