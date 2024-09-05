using Course_Management.models;
namespace Course_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] QuizLists = {
                "Who is our Teacher?",
                "What is the capital of Bangladesh?",
                "5 + 7 = ?",
                "What is the currency of Bangladesh?",
                "Who is the President of the United States?",
                "6 x 2 = ?",
                "What is the largest planet in our solar system?",
                "What is 10 divided by 2?",
                "Who wrote 'Romeo and Juliet'?",
                "Which country is famous for the Eiffel Tower?",
                };

            // Student s1 = new Student();
            // Instructor is1 = new Instructor();
            // Admin ad = new Admin();
            // Course c1 = new Course();
            // Blog b1 = new Blog();
            Quiz q1 = new Quiz("#1", "General Knowledge", QuizLists);


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
            // b1.CreateA_Blog();
            // b1.ShowBlogs();
            // b1.ShowComments();
            q1.OperateQuizes();
            q1.Marks();
        }
    }
}
