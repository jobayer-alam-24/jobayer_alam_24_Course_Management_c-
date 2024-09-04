namespace Course_Management.models
{
    public class Course
    {
        private string CourseID;
        private string CourseName;
        private string CourseInstructor;
        private string CourseDescription;
        private int CourseDuration;
        private int EnrollmentLimit;
        private List<string> EnrolledStudents {get;set;} = new List<string>();

        public void TakeCourseInfo()
        {
            Console.WriteLine($"=============Taking Course Info==========");
            Console.Write($"Course ID: ");
            CourseID = Console.ReadLine();
            Console.Write($"Course Name: ");
            CourseName = Console.ReadLine();
            Console.Write($"Course Instructor: ");
            CourseInstructor = Console.ReadLine();
            Console.Write($"Course Description: ");
            CourseDescription = Console.ReadLine();
            Console.Write($"Course Duration (Month): ");
            CourseDuration = int.Parse(Console.ReadLine());
        }
        public void SetStudentsLimit(int limit)
        {
            EnrollmentLimit = limit;
        }
        public void GetCourseDetails()
        {
            Console.WriteLine($"==============Course Details================");
            Console.WriteLine($"*||*  1. Course ID: #{CourseID}");
            Console.WriteLine($"*||*  2. Course Name: {CourseName}");
            Console.WriteLine($"*||*  3. Course Instructor: {CourseInstructor}");
            Console.WriteLine($"*||*  4. Course Duration: {CourseDuration} Month");
            Console.WriteLine($"*||*  5. Maximum Students: {EnrollmentLimit}");
            Console.WriteLine($"*||*  6. Course Description: {CourseDescription}");
            Console.WriteLine($"*||*  7. Availability: {IsAvailable()}");
            Console.WriteLine($"*||*  8. Current Students: {EnrolledStudents.Count}");
        }   
        public string IsAvailable()
        {
            if(EnrolledStudents.Count < EnrollmentLimit)
            {
                return "Available";
            }
            else
            {
                return "Not Available!";
            }
        }
        public bool AddStudent(string studentName)
        {
            if(EnrolledStudents.Count < EnrollmentLimit)
            {
                EnrolledStudents.Add(studentName);
                return true;
            }
            else {return false;}
        }
        public bool RemoveStudent(string studentName)
        {
            if(EnrolledStudents.Count > 0)
            {
                EnrolledStudents.Remove(studentName);
                return true;
            }
            else {return false;}
        }
    }
}