using System;
using ConsoleApp;

namespace ClassLibrary
{
	public class University
	{
		public University()
		{
		}
        Employee[] Employees = new Employee[0];
        Student[] Students = new Student[0];

		private string _name;
		public string Name
        {
			get => _name;
            set
            {
                if (value.Length > 2)
                {
					_name = value;
                }
            }
        }
		private int _workerLimit;
		public int WorkerLimit
        {
			get => _workerLimit;
            set
            {
                if (value > 1)
                {
                    _workerLimit = value;
                }
            }
        }
        private double _salaryLimit;
        public double SalaryLimit
        {
            get => _salaryLimit;
            set
            {
                if (_workerLimit*250 < value)
                {
                    _salaryLimit = value;
                }
            }
        }

        public double CalcSalaryAverage()
        {
            int count = 0;
            double totalSalary = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                totalSalary += Employees[i].Salary;
                count++;
            }
            if (count != 0)
            {
                return totalSalary / count;
            }
            else
            {
                return 0;
            }
        }



	}
}

