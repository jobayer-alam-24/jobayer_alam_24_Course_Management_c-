using Course_Management.models;
namespace Course_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] QuizLists = {
                "What is the capital of Bangladesh?",
                "2 + 4 = ?",
                "What is the Currency of Bangldesh?",
                "Who is the Prime Minister of Bangldesh?",
                "3 x 3 = ?"
                };
            Quiz q1 = new Quiz("#1", "General Knowledge", QuizLists);
            q1.OperateQuizes();
            q1.Marks();

            // Student s1 = new Student();
            // Instructor is1 = new Instructor();
            // Admin ad = new Admin();
            // Course c1 = new Course();
            // Blog b1 = new Blog();
            // b1.CreateA_Blog();
            // b1.ShowBlogs();
            // b1.ShowComments();

            // s1.TakeStudentsInfo();
            // s1.TakeCourseEnrollInfo();
            // s1.PrintInfo();
            // is1.TakeTeachersInfo();
            // is1.EnterTeachingCourses();
            // is1.PrintInfo();
            // ad.TakeAdminsInfo();
            // ad.PrintInfo();
            // c1.TakeCourseInfo();
            // c1.SetStudentsLimit(5);
            // c1.AddStudent("Rahim");
            // c1.AddStudent("Karim");
            // c1.AddStudent("Roma");
            // c1.RemoveStudent("Karim");
            // c1.AddStudent("Diana");
            // c1.GetCourseDetails();
        }
    }
}
