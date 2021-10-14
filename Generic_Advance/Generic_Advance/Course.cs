using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Advance
{
    class Student
    {
        public int StudentID;
        public string StudentName;

        public Student()
        {
        }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }

        public override string ToString()
        {
            return $"{StudentID} - {StudentName}";
        }
    }

    class Course
    {
        private int courseID;
        private string courseTitle;
        private Dictionary<Student, double> diction = new Dictionary<Student, double>();

        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }

        public delegate void NumberChanged(int oldNumber, int newNumber);
        public event NumberChanged OnNumberOfStudentChange;

        public Course(int courseID, string courseTitle)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
        }

        public void addStudent(Student s, double g)
        {
            diction.Add(s, g);
            if (OnNumberOfStudentChange != null)
            {
                OnNumberOfStudentChange.Invoke(diction.Count - 1, diction.Count);
            }
            //OnNumberOfStudentChange?.Invoke(diction.Count - 1, diction.Count);
        }

        public void RemoveStudent(int StudentID)
        {
            //foreach (KeyValuePair<Student, double> item in diction)
            foreach (var item in diction)
            {
                if (item.Key.StudentID == StudentID)
                {
                    diction.Remove(item.Key);
                    if (OnNumberOfStudentChange != null)
                    {
                        OnNumberOfStudentChange.Invoke(diction.Count + 1, diction.Count);
                    }

                }
            }
        }
        public override string ToString()
        {
            String result = $"Course: {CourseID} - {CourseTitle} \n";

            foreach (var item in diction)
            {
                result += $"Student: {item.Key} - Mark: {item.Value.ToString().Replace('.', ',')}\n";
            }
            return result;
        }
    }
}
