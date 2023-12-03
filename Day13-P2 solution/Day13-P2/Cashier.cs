using System;
namespace Day13_P2
{
	public class Cashier
	{
		private IPayments payment;

		public Cashier(IPayments payments)
		{
			this.payment = payments;
		}

		public void CheckOut(decimal amount)
		{
			payment.Pay(amount);
		}
	}
}

