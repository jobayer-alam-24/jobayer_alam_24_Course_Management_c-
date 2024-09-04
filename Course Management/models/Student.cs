using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Management.models
{
    public class Student : Person
    {
        public void TakeStudentsInfo()
        {
            Console.WriteLine($"==========Taking Student Input===========");
            Console.Write($"Enter your ID: ");
            ID = Console.ReadLine();
            Console.Write($"Enter your First Name: ");
            FirstName = Console.ReadLine();
            Console.Write($"Enter your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write($"Enter your Email: ");
            Email = Console.ReadLine();
            Console.Write($"Enter your Phone Number: ");
            PhoneNumber = Console.ReadLine();
        }
        public void TakeCourseEnrollInfo()
        {
            Console.WriteLine($"=========Taking Course Info======");
            Console.Write($"How many Courses do you want to Enroll: ");
            int courseNo = int.Parse(Console.ReadLine());
            string[] courses = new string[courseNo];
            for(int i = 0; i < courseNo; i++)
            {
               Console.Write($"Enter Course Name - {i + 1}: "); 
               courses[i] = Console.ReadLine();
            }
            Console.WriteLine($"===========Printing Course Info========");
            EnrollInCourse(courses);
        }
        public void EnrollInCourse(string[] Courses)
        {
            Console.Write($"Enrolled Course: ");
            int len = Courses.Length;
            PrintEnrollCourse(Courses, len);
            Console.WriteLine($"Enrollment Date: {DateTime.Now.ToString("dddd, dd-MMMM-yyyy")}");
            
        }
        
    }
}