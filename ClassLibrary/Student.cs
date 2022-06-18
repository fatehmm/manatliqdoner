using System;


namespace ClassLibrary
{
    public class Student
    {
        public string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                bool check = true;
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

        private int _groupNo;

        public int GroupNo
        {
            get => _groupNo;
            set
            {
                if (Math.Floor(Math.Log10(value) + 1) == 6)
                {
                    _groupNo = value;
                }
            }
        }
        private int _point;
        public int Point
        {
            get => _point;
            set
            {
                if (value>=0 && value <=100)
                {
                    _point = 100;
                }
            }
        }

    }
    
}

