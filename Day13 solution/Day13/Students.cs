using System;
namespace Day13
{
	public class Students
	{
		int absent;
		double hours;

		public Students()
		{
		}

        public override string ToString()
        {
            return base.ToString() + $" {(30- absent) * hours } ";
        }
    }
}

