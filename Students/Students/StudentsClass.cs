using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student
    {
        public string name;

        public string course;

        public int grade;

        public Student(string aName, string aCourse, int aGrade)
        {
            name = aName;
            course = aCourse;
            grade = aGrade;
        }
    }
}
