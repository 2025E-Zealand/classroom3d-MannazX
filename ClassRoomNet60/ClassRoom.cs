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
		List<Student> StudentList { get; set; }
		DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
             
        }
    }
}
