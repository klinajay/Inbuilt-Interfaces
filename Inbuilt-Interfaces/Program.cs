using Inbuilt_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        StudentRecord student1 = new StudentRecord("Ram" , 89 , 21);
        StudentRecord student2 = new StudentRecord("shyam", 50, 21);

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
    }
}