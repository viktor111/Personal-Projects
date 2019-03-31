using System;

namespace Students
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Number students: ");

            var numberofStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            var students = new Student[numberofStudents];

            for (int i = 0; i < numberofStudents; i++)
            {
                var studentName = string.Empty;
                var studentCourse = string.Empty;
                var studentGrade = 0;

                Console.Write("Name: ");
                studentName = Console.ReadLine();

                Console.Write("Course: ");
                studentCourse = Console.ReadLine();

                Console.Write("Grade: ");
                studentGrade = int.Parse(Console.ReadLine());

                Console.WriteLine();

                var student = new Student(studentName, studentCourse, studentGrade);

                students[i] = student;
            }

            Console.WriteLine();

            Console.WriteLine("-Students-");

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, Course: {student.course}, Grade: {student.grade}");
            }
        }
    }
}
