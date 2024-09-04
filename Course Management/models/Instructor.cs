namespace Course_Management.models
{
    public class Instructor : Person
    {
        private DateTime HireDate;
        private int TeachingCourseNumber;
        public void TakeTeachersInfo()
        {
            Console.WriteLine($"==========Taking Instructor Input===========");
            Console.Write($"Enter your ID Number: ");
            ID = Console.ReadLine();
            Console.Write($"Enter your First Name: ");
            FirstName = Console.ReadLine();
            Console.Write($"Enter your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write($"Enter your Email: ");
            Email = Console.ReadLine();
            Console.Write($"Enter your Phone Number: ");
            PhoneNumber = Console.ReadLine();
            Console.Write($"How many courses do you want to teach in: ");
            TeachingCourseNumber = int.Parse(Console.ReadLine());
            Console.Write($"Enter your Hiring Date (MM/dd/yyyy): ");
            HireDate = Convert.ToDateTime(Console.ReadLine());
            
        }
        public void EnterTeachingCourses()
        {
            string[] teachingCourses = new string[TeachingCourseNumber];
            Console.WriteLine($"========Enter Courses Name you want to Teach===========");
            for(int i = 0; i < TeachingCourseNumber; i++)
            {
                Console.Write($"Enter Course {i + 1}: ");
                teachingCourses[i] = Console.ReadLine();
            }
            Console.WriteLine($"============Teaching Courses Info=========");
            Console.Write($"Your Teaching Course Lists: ");
            PrintEnrollCourse(teachingCourses, teachingCourses.Length);
            Console.WriteLine($"Hiring Date: {HireDate.ToString("dddd, dd-MMMM-yyyy")}");
        }
        public override void PrintInfo()
        {
            CommonInfo("Instructor's");
        }
    }
}