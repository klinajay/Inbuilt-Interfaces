using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbuilt_Interfaces
{
    internal class StudentRecord : ICloneable
    {
        public List<Student> students;

        public StudentRecord()
        {
            students = new List<Student>();
        }
        public Object Clone()
        {
            List<Student> list = new List<Student>();
            StudentRecord result = new StudentRecord();
            foreach (var student in students)
            {
                if (student.percentage > 75) list.Add(student);

            }
            result.students = list;
            return result;
        }
        public void AddStudents(Student student)
        {
            students.Add(student);
        }
        public void PrintList()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.studentName} {student.percentage}");
            }
        }
    }
}
