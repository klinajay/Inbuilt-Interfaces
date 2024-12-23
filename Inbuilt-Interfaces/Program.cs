using Inbuilt_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Student student1 = new Student("Ram" , 89 , 21);
        Student student2 = new Student("shyam", 50, 21);

        if(student1.CompareTo(student2) == 1 )
        {
            Console.WriteLine($"{student2.studentName} performed well than {student1.studentName}");
        }
        else if(student1.CompareTo(student2) == -1 )
        {
            Console.WriteLine($"{student1.studentName} performed well than {student2.studentName}");
        }
        else
        {
            Console.WriteLine($"Both {student1} and {student2} performed equally");
        }

        StudentRecord record = new StudentRecord();
        record.AddStudents(student1);
        record.AddStudents(student2);


        Console.WriteLine("Students who scores more than 75% are....");
        StudentRecord record1 = (StudentRecord) record.Clone();

        record1.PrintList();

    }
}