using Course_Management.models;
namespace Course_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Instructor is1 = new Instructor();
            Admin ad = new Admin();
            Course c1 = new Course();
            
            // s1.TakeStudentsInfo();
            // s1.TakeCourseEnrollInfo();
            // s1.PrintInfo();
            // is1.TakeTeachersInfo();
            // is1.EnterTeachingCourses();
            // is1.PrintInfo();
            // ad.TakeAdminsInfo();
            // ad.PrintInfo();
            c1.TakeCourseInfo();
            c1.SetStudentsLimit(5);
            c1.AddStudent("Rahim");
            c1.AddStudent("Karim");
            c1.AddStudent("Roma");
            c1.RemoveStudent("Karim");
            c1.AddStudent("Diana");
            c1.GetCourseDetails();
        }
    }
}
