using System;
namespace ConsoleApp
{
	public class Employee
	{
		public Employee(string department)
		{
            DepartmentName = department;
            _no = $"{DepartmentName.Substring(0, 2)}{_totalcount}";
            _totalcount++;

		}
		private string _fullName;
		public string FullName
        {
			get => _fullName;
            set
            {
;               bool check = true;
                string[] names = value.Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < names[0].Length; i++)
                    {
                        if (!Char.IsLetter(names[0][i]))
                        {
                            check = false;
                        }
                    }
                }
                if (check == true && names.Length == 2)
                {
                    _fullName = $"{Char.ToUpper(names[0][0])}{names[0].Substring(1)} {Char.ToUpper(names[1][0])}{names[1].Substring(1)}";
                }
                
                
            }
        }
        private string _position;
        public string Position
        {
            get => _position;
            set
            {
                if (value.Length>2)
                {
                    _position = $"{Char.ToUpper(value[0])}{value.Substring(1)}";
                }
            }
        }
        private double _salary;
        public double Salary
        {
            get => _salary;
            set
            {
                if (value>250)
                {
                    _salary = value;
                }
            }
        }
        public string DepartmentName;
        private static int _totalcount = 1000;
        private string _no;

        //enum EmployeeType
        //{
        //    Fulltime,
        //    Parttime,
        //    Adjunct
        //};
        


    }
}

