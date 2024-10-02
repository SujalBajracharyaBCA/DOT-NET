using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8b
{ 
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    class Program
    {
        static void Main()
        {
          
            List<Student> students = new List<Student>
        {
            new Student { Name = "laxmi", Marks = 85 },
            new Student { Name = "Sujal", Marks = 92 },
            new Student { Name = "Kishore", Marks = 88 },
            new Student { Name = "Unique", Marks = 95 },
            new Student { Name = "Akal", Marks = 90 }
        };
            var topStudents = from student in students
                              where student.Marks > 90
                              select student.Name;

            Console.WriteLine("Students with marks above 90:");
            foreach (var name in topStudents)
            {
                Console.WriteLine(name);
            }
        }
    }


}
