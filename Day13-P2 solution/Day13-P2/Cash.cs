using System;
namespace Day13_P2
{
	public interface IPayments
	{
		void Pay(decimal amounts);
	}

	public class Cash : IPayments
	{
		public void Pay(decimal amounts)
		{
			Console.WriteLine($"{amounts} using cash");
		}
	}

    public class VisaCard : IPayments
    {
        public void Pay(decimal amounts)
        {
            Console.WriteLine($"{amounts} using VisaCard");
        }
    }

    public class MasterCard : IPayments
    {
        public void Pay(decimal amounts)
        {
            Console.WriteLine($"{amounts} using Master Card");
        }
    }

    public class Debit : IPayments
    {
        public void Pay(decimal amounts)
        {
            Console.WriteLine($"{amounts} using Debit");
        }
    }
}

