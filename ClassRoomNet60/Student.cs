using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ClassRoomNet60
{
	public class Student
	{
        private int _birthMonth;
        public string Name { get; private set; }
		public int BirthMonth
        {
            get { return _birthMonth; } 
            private set
            {
                if (value >= 1 && value <= 12)
                {
                    _birthMonth = value;
                }
                else
                {
                    throw new Exception("This value is not inside the valid range.");
                }
            }
        }
		public int BirthDay { get; private set; }

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string Season()
        {
            switch (BirthMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return $"The given Birthmonth is not inside the valid range";
            }
        }

		public override string ToString()
		{
            return $"Name: {Name}, Birthmonth: {BirthMonth}, Birthday: {BirthDay}";
		}
	}
}
