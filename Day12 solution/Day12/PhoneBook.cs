using System;
namespace Day12
{
	public class PhoneBook
	{
		public static int cnt;
        string[] Names;
		long[] Numbers;
		int size;

		public PhoneBook(int size)
		{
			this.size = size;
			this.Names = new string[size];
			this.Numbers = new long[size];
		}

		public int Getsize()
		{
			return this.size;
		}

		public void add( string name, long number)
		{
			cnt += 1;
            this.Names[cnt] = name;
			this.Numbers[cnt] = number;
		}

		public void GetAll()
		{
			for (int i = 0; i < Names.Length; i++)
			{
				if (Names[i] != null)
					Console.WriteLine($"{i+1}- {this.Names[i]}  ,  {this.Numbers[i]}" );
            }
		}

		public long GetNum(string name)
		{
			for (int i = 0; i < Numbers.Length; i++)
			{
				if (Names[i] == name)
					return Numbers[i];
			}
			return -1;
        }

		public void EditNum(string name, long number)
		{
			for (int i = 0; i < Numbers.Length; i++)
			{
				if (Names[i] == name)
				{
					Numbers[i] = number;
					Console.WriteLine($"{Names[i]} , Phone number is updated {Numbers[i]}");
				}
			}
		}
		
       public long this[string name]
		{
			get
			{
				for (int i = 0; i < this.size; i++)
					if (Names[i] == name)
						return Numbers[i];
				return 0;
			}
			set
			{
				Names[cnt] = name;
				Numbers[cnt] = value;
                cnt += 1;
            }
		}


	}
}

