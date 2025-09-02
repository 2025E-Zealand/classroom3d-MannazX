using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
	public class ClassRoom
	{
        public string ClassName { get; set; }
		public List<Student> StudentList { get; set; }
		public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            StudentList = new List<Student>();
            SemesterStart = new DateTime();
        }

        public void SeasonBirthdaysCounts()
        {
            Dictionary<string, int> seasonCount = new Dictionary<string, int>()
            {
                { "Winter", 0 },
                { "Spring", 0 },
                { "Summer", 0 },
                { "Autumn", 0 }
            };

            foreach (Student student in StudentList)
            {
                if (student.Season() == "Winter")
                {
                    seasonCount["Winter"]++;
                }
                else if (student.Season() == "Spring")
                {
                    seasonCount["Spring"]++;
                }
                else if (student.Season() == "Summer")
                {
                    seasonCount["Summer"]++;
                }
                else if (student.Season() == "Autumn")
                {
                    seasonCount["Autumn"]++;
                }
            }

            foreach (var item in seasonCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
