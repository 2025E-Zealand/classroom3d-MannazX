// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom classRoom = new ClassRoom();
classRoom.ClassName = "3Q";
classRoom.SemesterStart = Convert.ToDateTime("26-08-2019");

Student magnus = new Student("Magnus", 6, 27);
Student vincent = new Student("Vincent", 3, 20);
Student kristoffer = new Student("Kristoffer", 4, 16);

classRoom.StudentList.Add(magnus);
classRoom.StudentList.Add(vincent);
classRoom.StudentList.Add(kristoffer);

Console.WriteLine($"Classroom name {classRoom.ClassName}");
Console.WriteLine();
Console.WriteLine($"Semester Start Date {classRoom.SemesterStart}");
Console.WriteLine();

foreach (Student student in classRoom.StudentList)
{
    Console.WriteLine(student.ToString());
}
Console.WriteLine();

classRoom.SeasonBirthdaysCounts();