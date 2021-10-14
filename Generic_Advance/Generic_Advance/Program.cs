using System;

namespace Generic_Advance
{

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Trung");
            Course c = new Course(1, "PRN211_Sum21");
            c.addStudent(s, 7.5);
            c.addStudent(new Student(2, "Hoa"), 7.8);
            c.addStudent(new Student(3, "Vinh"), 7.4);
            Console.WriteLine(c);
            c.RemoveStudent(2);
            Console.WriteLine("\n------------After remove: ");
            Console.WriteLine(c);

            Console.WriteLine("\n------------After add event handler:");
            c.OnNumberOfStudentChange += Notify;
            c.addStudent(new Student(4, "Hoang Anh"), 8);
            c.RemoveStudent(1);
            Console.WriteLine(c);
            Console.ReadLine();
        }

        private static void Notify(int oldNumber, int newNumber)
        {
            Console.WriteLine($"Number of student has changed from {oldNumber} to {newNumber}.");
        }
    }
}
