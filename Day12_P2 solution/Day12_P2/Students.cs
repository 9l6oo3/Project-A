using System;
using System.Xml.Linq;

namespace Day12_P2
{
	public class Students :Human
	{
		string qualification;
		bool isIntern;
		int totalGrade;
        int studentHours;

		public Students(string qualification, bool isIntern, int totalGrade, int studentHours, string name, bool hasJob, int age, bool isMarried) : base ( name,  hasJob,  age,  isMarried)
        {
			this.qualification = qualification;
			this.isIntern = isIntern;
			this.totalGrade = totalGrade;
			this.studentHours = studentHours;
		}

        public void EmployeeInfo()
        {
            Console.WriteLine($"ID: {Id} \n,Name: {name} , {hasJob}, {totalGrade} , {studentHours}, {qualification} , {isIntern}");
            
        }

    }
}

