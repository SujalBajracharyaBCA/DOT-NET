using System;

namespace Lab5
{
    public class Student
    {
        // Static field
        private static int numberOfStudents = 0;

        // Properties
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor for full information
        public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
        {
            FullName = fullName;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;
            numberOfStudents++;
        }

        // Constructor with fullName and course
        public Student(string fullName, string course)
        {
            FullName = fullName;
            Course = course;
            Subject = null;
            University = null;
            Email = null;
            PhoneNumber = null;
            numberOfStudents++;
        }

        // Constructor with fullName, course, and subject
        public Student(string fullName, string course, string subject)
        {
            FullName = fullName;
            Course = course;
            Subject = subject;
            University = null;
            Email = null;
            PhoneNumber = null;
            numberOfStudents++;
        }

        // Static method to get the number of students
        public static int GetNumberOfStudents()
        {
            return numberOfStudents;
        }

        // Method to display complete information about the student
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine($"Full Name: {FullName ?? "N/A"}");
            Console.WriteLine($"Course: {Course ?? "N/A"}");
            Console.WriteLine($"Subject: {Subject ?? "N/A"}");
            Console.WriteLine($"University: {University ?? "N/A"}");
            Console.WriteLine($"Email: {Email ?? "N/A"}");
            Console.WriteLine($"Phone Number: {PhoneNumber ?? "N/A"}");
           
        }
    }
    class StudentTest
    {
        static void Main(string[] args)
        {
            // Creating student objects with different constructors
            Student student1 = new Student("Sujal", "BCA", "DSA", "TU", "sujalbajracharya124@gamal.com", "9823863299");
            Student student2 = new Student("Prabal", "Computer Engineering", "Mechanics");
            Student student3 = new Student("Pratisara", "Computer Engineering", "Digital Logic", "KU", "pratisara234@gmail.com", "9876543210");
            Student student4 = new Student("Rupa", "Biology");

            // Displaying information about students
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();
            student3.DisplayStudentInfo();
            student4.DisplayStudentInfo();

            // Displaying the number of created student objects
            Console.WriteLine($"Total number of students created: {Student.GetNumberOfStudents()}");

            // Pause the console to view results
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
