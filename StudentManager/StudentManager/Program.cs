using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No of students in class?");
            var studentCount = int.Parse(Console.ReadLine());
            var studentGrades = new int[studentCount];
            var studentNames = new string[studentCount];
            for (int i=0;i<studentCount;i++)
            {
                Console.Write("student name:");
                studentNames[i] = Console.ReadLine();

                Console.Write("student grade");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0},Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
